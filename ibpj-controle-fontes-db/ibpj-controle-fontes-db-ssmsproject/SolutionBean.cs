using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ibpj_controle_fontes_db_conf;

namespace ibpj_controle_fontes_db_ssmsproject
{
    public class SolutionBean
    {
        const String str_cabecalho = "Microsoft Visual Studio Solution File, Format Version 12.00\n"+
                                    "VisualStudioVersion = 14.0.23107.0\n"+
                                    "MinimumVisualStudioVersion = 10.0.40219.1\n";
        List<ProjectBean> projects { get; set; }

        public static void solutionDefault(String solutionName, String solutionPath, String branchName, String newProjects = "")
        {
            String fullPath = solutionPath + @"\" + solutionName;
            String fileName = solutionName + ".ssmssln";
            String[] lstNewProjects = newProjects.Split(',');

            SolutionBean solutionBean = SolutionBean.contentFileSolution(fullPath, fileName, branchName);

            if(newProjects!="")
                for (int indexOfArrayProjects = 0; indexOfArrayProjects < lstNewProjects.Length; indexOfArrayProjects++)
                {
                    solutionBean.addProjectSolution(solutionBean, branchName, lstNewProjects[indexOfArrayProjects], true, false, fullPath);
                }

            
            Utilitarios.createFile
            (
                fullPath, 
                fileName, 
                SolutionBean.solutionFileDefault
                (
                    solutionBean,
                    fullPath
                )
            );
        }

        public SolutionBean addProjectSolution(SolutionBean solutionBean, String parent_project_name, String project_name, bool isFile, bool defaultQueries, String path)
        {
            Utilitarios.logExibeParametros(new string[] {parent_project_name, project_name, isFile.ToString(), defaultQueries.ToString(), path});
            Utilitarios.logExibeParametros(new string[] {"Total projetos: ",solutionBean.projects.Count.ToString()});
            solutionBean.projects.Add(ProjectBean.addNewProject(solutionBean.projects,parent_project_name, project_name, isFile, defaultQueries, path));
            Utilitarios.logExibeParametros(new string[] { "Total projetos: ", solutionBean.projects.Count.ToString() });
            return solutionBean;
        }

        public static SolutionBean loadSolutionFile(String path, String file)
        {
            String[] lines = File.ReadAllLines(path + @"\" + file);
            List<ProjectBean> ret_projects = new List<ProjectBean>();
            bool isProject = false;
            bool isGlobal = false;

            //Varre o arquivo
            for (int indexOfLine = 0; indexOfLine < lines.Length; indexOfLine ++)
            {
                String line = lines[indexOfLine];

                //Verifica os projetos
                if (line.Length > 6)
                {
                    if(line.Substring(0,7) == "Project" && !isProject)
                    {
                        isProject = true;

                        
                        String[] project_detail = line.Split('=');
                        String[] project_data = project_detail[1].Replace("\"","").Split(',');

                        String parm_solution_id = project_detail[0].Replace("Project","").Replace("(","").Replace(")","").Replace("\"","").Trim();
                        String parm_project_id = project_data[2].Trim();
                        String parm_parent_project_id = "0";
                        String parm_project_name = project_data[0].Trim();
                        String parm_project_path = project_data[1].Trim();
                        String parm_project_physical_path = parm_project_path.Replace(@"\" + parm_project_name + ".ssmssqlproj", "");
                        bool parm_isFile = project_data[0] != project_data[1] ? true : false;
                        SqlWorkbenchSqlProject parm_data_file_project = new SqlWorkbenchSqlProject();

                        if(parm_isFile)
                        {
                            StreamReader projectFile = new StreamReader(path + @"\" + parm_project_path);
                            XmlSerializer xmlFile = new XmlSerializer(typeof(SqlWorkbenchSqlProject));
                            parm_data_file_project = (SqlWorkbenchSqlProject)xmlFile.Deserialize(projectFile);
                            projectFile.Close();
                        }

                        ret_projects.Add
                            (
                                new ProjectBean().createProject
                                (
                                    parm_solution_id,
                                    parm_project_id,
                                    parm_parent_project_id,
                                    parm_project_name,
                                    parm_project_path,
                                    parm_project_physical_path,
                                    parm_isFile,
                                    parm_data_file_project
                                 )
                             );
                    }
                    else
                    {
                        isProject = false;

                        if (line.Trim() == "EndGlobalSection" && isGlobal)
                            isGlobal = false;


                        if (isGlobal)
                        {
                            String[] globalNested = line.Trim().Split('=');
                            Console.WriteLine("Project: " + globalNested[0] + "Parent:" + globalNested[1]);
                            foreach (ProjectBean project in ret_projects)
                                project.setParentProjectId(globalNested[0].Trim(),globalNested[1].Trim());
                        }

                        if (line.Trim() == "GlobalSection(NestedProjects) = preSolution")
                            isGlobal = true;
                        
                    }
                        
                }
            }
            
            return new SolutionBean() { projects = ret_projects};
        }

        public static SolutionBean contentFileSolution(String path, String file, String branchName)
        {
            // cria o diretorio da solução
            Utilitarios.createDirectory(path);

            //SolutionBean ret = new SolutionBean();

            //Verifica se já existe a solução para que seja adicionado o novo projeto e estrutura de pastas
            if (File.Exists(path + @"\" + file))
            {
                SolutionBean solutionBean = SolutionBean.loadSolutionFile(path, file);
                if (!solutionBean.projects.Exists(x => x.getName() == branchName))
                {
                    List<ProjectBean> projectsDefaults = ProjectBean.projectsDefault(branchName, path);
                    foreach (ProjectBean projectBean in projectsDefaults)
                    {
                        solutionBean.projects.Add(projectBean);
                    }
                }

                return solutionBean;
            }
            else
                return new SolutionBean() { projects = ProjectBean.projectsDefault(branchName, path) };
                    
            //return ret;
        }

        public static String solutionFileDefault(SolutionBean solution, String rootPath)
        {
            String ret = str_cabecalho + "\n";

            //Project EndProject
            foreach (ProjectBean project in solution.projects)
            {
                ret += ProjectBean.projectToString(project) + "\n";
            }

            ret += "\n\n";
            ret += "Global\n";
            ret += "\tGlobalSection(NestedProjects) = preSolution\n";

            foreach (ProjectBean project in solution.projects)
            {
                if (ProjectBean.isChild(project))
                    ret += "\t\t" + ProjectBean.nestedProjectsToString(project) + "\n";

                // gera o arquivo do projeto
                ProjectBean.createProjectFileDefault(project,rootPath);
            }
            ret += "\tEndGlobalSection\n";
            ret += "EndGlobal";

            return ret;
        }
    }
}
