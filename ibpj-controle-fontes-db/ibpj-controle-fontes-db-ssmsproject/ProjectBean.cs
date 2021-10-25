using ibpj_controle_fontes_db_conf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_fontes_db_ssmsproject
{
    class ProjectBean
    {
        public const String unique_id_folder = "{2150E333-8FDC-42A3-9474-1A3956D46DE8}";
        public const String unique_id_project = "{4F2E2C19-372F-40D8-9FA7-9D2138C6997A}";

        String solution_id { get; set; }
        String project_id { get; set; }
        String parent_project_id { get; set; }
        String project_name { get; set; }
        String project_path { get; set; }
        String project_physical_path { get; set; }
        bool isFile { get; set; }
        SqlWorkbenchSqlProject data_file_project { get; set; }

        public static String wellFormatedUniqueId()
        {
            return "{" + Utilitarios.generateUniqueIdProject() + "}";
        }

        public ProjectBean createProject
            (
            String parm_solution_id,
            String parm_project_id,
            String parm_parent_project_id,
            String parm_project_name,
            String parm_project_path,
            String parm_project_physical_path,
            bool parm_isFile,
            SqlWorkbenchSqlProject parm_data_file_project
            )
        {
            return new ProjectBean()
            {
                solution_id             = parm_solution_id,
                project_id              = parm_project_id,
                parent_project_id       = parm_parent_project_id,
                project_name            = parm_project_name,
                project_path            = parm_project_path,
                project_physical_path   = parm_project_physical_path,
                isFile                  = parm_isFile,
                data_file_project       = parm_data_file_project
            };
        }

        public static List<ProjectBean> projectsDefault(String branchName, String path)
        {
            String projectIdFolderBranch = ProjectBean.wellFormatedUniqueId();
            String projectIdFolderOfpjd000 = ProjectBean.wellFormatedUniqueId();
            String projectIdFolderOfpjd001 = ProjectBean.wellFormatedUniqueId();
            String projectIdOfpjd000Ida = ProjectBean.wellFormatedUniqueId();
            String projectIdOfpjd000Volta = ProjectBean.wellFormatedUniqueId();
            String projectIdOfpjd001Ida = ProjectBean.wellFormatedUniqueId();
            String projectIdOfpjd001Volta = ProjectBean.wellFormatedUniqueId();

            List<ProjectBean> projects = new List<ProjectBean>()
            { 
                // 1.Branch
                new ProjectBean()
                {
                    solution_id = unique_id_folder,
                    project_id = projectIdFolderBranch,
                    parent_project_id = "0",
                    project_name = branchName,
                    project_path = branchName,
                    isFile = false,
                    project_physical_path = branchName
                },
                // 1.1.OFPJD000

                new ProjectBean()
                {
                    solution_id = unique_id_folder,
                    project_id = projectIdFolderOfpjd000,
                    parent_project_id = projectIdFolderBranch,
                    project_name = "OFPJD000",
                    project_path = "OFPJD000",
                    isFile = false,
                    project_physical_path = branchName + @"\OFPJD000"
                },
                // 1.2.OFPJD001

                new ProjectBean()
                {
                    solution_id = unique_id_folder,
                    project_id = projectIdFolderOfpjd001,
                    parent_project_id = projectIdFolderBranch,
                    project_name = "OFPJD001",
                    project_path = "OFPJD001",
                    isFile = false,
                    project_physical_path = branchName + @"\OFPJD001"
                },

                // 1.1.1.IDA
                new ProjectBean()
                {
                    solution_id = unique_id_project,
                    project_id = projectIdOfpjd000Ida,
                    parent_project_id = projectIdFolderOfpjd000,
                    project_name = "IDA",
                    project_path = branchName + @"\OFPJD000\IDA\IDA.ssmssqlproj",
                    data_file_project = new SqlWorkbenchSqlProject()
                    {
                        Name = "IDA",
                        Items = LogicalFolder.createLogicalFolderDefault
                        (
                            ConnectionNode.connectionNodesDefaultOfpjd000(),
                            FileNode.fileNodesDefaultOfpjd000Ida()
                        )
                    },
                    isFile = true,
                    project_physical_path = branchName + @"\OFPJD000\IDA"
                },
                // 1.1.2.VOLTA
                new ProjectBean()
                {
                    solution_id = unique_id_project,
                    project_id = projectIdOfpjd000Volta,
                    parent_project_id = projectIdFolderOfpjd000,
                    project_name = "VOLTA",
                    project_path = branchName + @"\OFPJD000\VOLTA\VOLTA.ssmssqlproj",
                    data_file_project = new SqlWorkbenchSqlProject()
                    {
                        Name = "VOLTA",
                        Items = LogicalFolder.createLogicalFolderDefault
                        (
                            ConnectionNode.connectionNodesDefaultOfpjd000(),
                            FileNode.fileNodesDefaultOfpjd000Volta()
                        )
                    },
                    isFile = true,
                    project_physical_path = branchName + @"\OFPJD000\VOLTA"
                },

                // 1.2.1.IDA
                new ProjectBean()
                {
                    solution_id = unique_id_project,
                    project_id = projectIdOfpjd001Ida,
                    parent_project_id = projectIdFolderOfpjd001,
                    project_name = "IDA",
                    project_path = branchName + @"\OFPJD001\IDA\IDA.ssmssqlproj",
                    data_file_project = new SqlWorkbenchSqlProject()
                    {
                        Name = "IDA",
                        Items = LogicalFolder.createLogicalFolderDefault
                        (
                            ConnectionNode.connectionNodesDefaultOfpjd001(),
                            FileNode.fileNodesDefaultOfpjd001Ida()
                        )
                    },
                    isFile = true,
                    project_physical_path = branchName + @"\OFPJD001\IDA"
                },
                // 1.2.2.VOLTA
                new ProjectBean()
                {
                    solution_id = unique_id_project,
                    project_id = projectIdOfpjd001Volta,
                    parent_project_id = projectIdFolderOfpjd001,
                    project_name = "VOLTA",
                    project_path = branchName + @"\OFPJD001\VOLTA\VOLTA.ssmssqlproj",
                    data_file_project = new SqlWorkbenchSqlProject()
                    {
                        Name = "VOLTA",
                        Items = LogicalFolder.createLogicalFolderDefault
                        (
                            ConnectionNode.connectionNodesDefaultOfpjd001(),
                            FileNode.fileNodesDefaultOfpjd001Volta()
                        )
                    },
                    isFile = true,
                    project_physical_path = branchName + @"\OFPJD001\VOLTA"
                }
            };

            //cria os diretorios de cada projeto
            foreach (ProjectBean project in projects)
            {
                Utilitarios.createDirectory(path + @"\" + project.project_physical_path);
            }

            return projects;
        }

        public void setParentProjectId(String project_id, String parent_project_id)
        {
            if (this.project_id == project_id)
                this.parent_project_id = parent_project_id;
        }

        public static String projectToString(ProjectBean project)
        {
            return "Project(\"" + project.solution_id + "\") = \"" + 
                project.project_name + "\", \"" + 
                project.project_path + "\", \"" + 
                project.project_id + "\"\nEndProject";
        }

        public static bool isChild(ProjectBean project)
        {
            if (project.parent_project_id == "0")
                return false;
            else
                return true;
        }

        public static String nestedProjectsToString(ProjectBean project)
        {
            return project.project_id + " = " + project.parent_project_id;
        }

        public static void createProjectFileDefault(ProjectBean project, String rootPath)
        {
            try
            {
                if(project.isFile)
                {
                    System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(SqlWorkbenchSqlProject));
                    System.IO.FileStream file = Utilitarios.createFile(rootPath, project.project_path);
                    xml.Serialize(file, project.data_file_project);
                    file.Close();

                    //Cria arquivos de query do projeto
                    foreach (LogicalFolder logicalFolder in project.data_file_project.Items)
                    {
                        if(logicalFolder.Name == "Queries")
                        {
                            if(logicalFolder.Items.FileNode.Length > 0)
                            {
                                foreach (FileNode fileNode in logicalFolder.Items.FileNode)
                                {
                                    Utilitarios.createFile(rootPath + @"\" + project.project_physical_path,
                                        fileNode.Name,
                                        Utilitarios.queryFile(fileNode.Name));
                                }
                            }
                            
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {
                Utilitarios.logExibeParametros(new string[] { "Erro na geração do arquivo ssmssqlproj." });
                Utilitarios.logExibeParametros(new string[] { e.StackTrace });
                throw;
            }

            //Inclui o elemento Items
        }

        public static ProjectBean addNewProject(List<ProjectBean> projects, String parent_project_name, String project_name, bool isFile, bool defaultQueries, String path)
        {
            String projectId = ProjectBean.wellFormatedUniqueId();

            foreach (ProjectBean project in projects)
            {
                if(project.project_physical_path == parent_project_name)
                {
                    Utilitarios.createDirectory
                        (
                            path +
                            (
                                isFile ?
                                @"\" + parent_project_name + @"\" + project_name : 
                                @"\" + project_name
                            )
                        );

                    return new ProjectBean()
                    {
                        solution_id = isFile ? unique_id_project : unique_id_folder,
                        project_id = projectId,
                        parent_project_id = project.project_id,
                        project_name = project_name,
                        project_path = isFile ? parent_project_name + @"\" + project_name + @"\" + project_name + ".ssmssqlproj" : project_name,
                        data_file_project = !isFile ? null :
                        new SqlWorkbenchSqlProject()
                        {
                            Name = project_name,
                            Items = LogicalFolder.createLogicalFolderDefault
                        (
                            ConnectionNode.connectionNodesDefaultOfpjd000(),
                            FileNode.fileNodesDefaultOfpjd000Ida()
                        )
                        },
                        isFile = isFile,
                        project_physical_path = parent_project_name + @"\" + project_name
                    };
                }
            }
            return new ProjectBean();
        }

        public String getName()
        {
            return this.project_name;
        }
    }
}
