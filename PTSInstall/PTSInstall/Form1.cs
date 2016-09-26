using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PTSInstall
{
    public partial class Form1 : Form
    {
        private string m_WindowsHomeFolder = string.Empty;
        public string WindowsHomeFolder
        {
            get { return m_WindowsHomeFolder; }
            set { m_WindowsHomeFolder = value; }
        }

        private string m_AppHomeFolder = string.Empty;
        public string AppHomeFolder
        {
            get { return m_AppHomeFolder; }
            set { m_AppHomeFolder = value; }
        }


        private bool m_AppHomeFolderCreated = false;
        public bool AppHomeFolderCreated
        {
            get { return m_AppHomeFolderCreated; }
            set { m_AppHomeFolderCreated = value; }
        }

        private string Version = "1.0.0.0";  // used to set current app version
        public Form1()
        {
            InitializeComponent();
            //this.= string.Format("PTS Installation - Version {0}", Version);

            // get Windows home folder
            DirectoryInfo dirWindowsFolder = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.Windows));
            WindowsHomeFolder = dirWindowsFolder.Name.ToString();
            WindowsHomeFolder = dirWindowsFolder.Root.Name.ToString();

            AppHomeFolder = System.AppDomain.CurrentDomain.BaseDirectory;

            int stop = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createPTSFolders_Button_Click(object sender, EventArgs e)
        {
            AppHomeFolderCreated = false;
            if (!setupAppFolders())
            {
                MessageBox.Show("Unable to create PTS installation folder.\nPTS installation can't be complete!",
                                "Important Message");
                AppHomeFolderCreated = false;
            }
            else
            {
                MessageBox.Show("All PTS installation folders successfully created!",
                                "Important Message");
                AppHomeFolderCreated = true;
            }
        }

        private void installGtkSharpButton_Click(object sender, EventArgs e)
        {
            if (!InstallGtkSharpPackage())
            {
                MessageBox.Show("GTK Sharp package installation failed!",
                                "Important Message");
            }
            else
            {
                MessageBox.Show("GTK Sharp package successfully installed!",
                                "Important Message");
            }
        }

        private void installDotNetFrameworkButton_Click(object sender, EventArgs e)
        {
            if (!InstallDotNetPackage())
            {
                MessageBox.Show("MS .NET Framework package installation failed!",
                               "Important Message");
            }
            else
            {
                MessageBox.Show("MS .NET Framework package successfully installed!",
                                "Important Message");
            }
        }

        private void installPTSAppButton_Click(object sender, EventArgs e)
        {
            if (!AppHomeFolderCreated)
            {
                MessageBox.Show("Please do SETP1 first to create PTS installation folders!",
                                "Important Message");

                return;

            }
            else
            {
                bool ok = CopyPTSInstallationFiles();
                if (!ok)
                {
                    MessageBox.Show("Unable to copy some or all PTS installation files!",
                                "Important Message");
                }
                else
                {
                    MessageBox.Show("All PTS installation files successfully copied!",
                                "Important Message");
                }
            }
        }

        private bool setupAppFolders()
        {
            bool ok = true;
            string folderPath = System.IO.Path.Combine(WindowsHomeFolder, "Rigaku", "PTS");
            folderPath.Trim();
                       
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    // create it
                    try
                    {
                        DirectoryInfo di = Directory.CreateDirectory(folderPath);
                    }
                    catch (Exception ex)
                    {
                        string strMsg = string.Format("{0}", ex.Message.ToString());
                        MessageBox.Show(strMsg, "Important Message");
                        return false;
                    }
                }

                if (Directory.Exists(folderPath))
                {
                    string folder = System.IO.Path.Combine(folderPath, "run");
                    if (!Directory.Exists(folder))
                    {
                        // create it
                        try
                        {
                            DirectoryInfo di = Directory.CreateDirectory(folder);
                        }
                        catch (Exception ex)
                        {
                            string strMsg = string.Format("{0}", ex.Message.ToString());
                            MessageBox.Show(strMsg, "Important Message");
                            return false;
                        }
                    }

                    if (Directory.Exists(folder))
                    {
                        folder = System.IO.Path.Combine(folderPath, "run", "shm", "comm");
                        if (!Directory.Exists(folder))
                        {
                            // create it
                            try
                            {
                                DirectoryInfo di = Directory.CreateDirectory(folder);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }

                        folder = System.IO.Path.Combine(folderPath, "run", "shm", "spect_data");
                        if (!Directory.Exists(folder))
                        {
                            // create it
                            try
                            {
                                DirectoryInfo di = Directory.CreateDirectory(folder);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }

                        folder = System.IO.Path.Combine(folderPath, "run", "shm", "comm_archives");
                        if (!Directory.Exists(folder))
                        {
                            // create it
                            try
                            {
                                DirectoryInfo di = Directory.CreateDirectory(folder);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }
                    }

                    // create default folders for saving System and OE data 
                    folder = System.IO.Path.Combine(folderPath, "Manufacturing_Local");
                    if (!Directory.Exists(folder))
                    {
                        // create it
                        try
                        {
                            DirectoryInfo di = Directory.CreateDirectory(folder);
                        }
                        catch (Exception ex)
                        {
                            string strMsg = string.Format("{0}", ex.Message.ToString());
                            MessageBox.Show(strMsg, "Important Message");
                            return false;
                        }
                    }

                    if (Directory.Exists(folder))
                    {
                        // create folder for saving System data
                        folder = System.IO.Path.Combine(folderPath, "Manufacturing_Local", "Shipped Instruments", "Progeny");
                        if (!Directory.Exists(folder))
                        {
                            // create it
                            try
                            {
                                DirectoryInfo di = Directory.CreateDirectory(folder);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }

                        // create folder for saving OE data
                        folder = System.IO.Path.Combine(folderPath, "Manufacturing_Local", "Optical Engines", "Progeny 1064");
                        if (!Directory.Exists(folder))
                        {
                            // create it
                            try
                            {
                                DirectoryInfo di = Directory.CreateDirectory(folder);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ok = false;
            }
            return ok;
        }


        private bool CopyPTSInstallationFiles()
        {
            bool ok = true;

            string sourceFolder = AppHomeFolder.Trim();
            string destinationFolder = System.IO.Path.Combine(WindowsHomeFolder, "Rigaku", "PTS");
            if(Directory.Exists(destinationFolder))
            {
                // PTS files
                string[] filePaths = Directory.GetFiles(System.IO.Path.Combine(sourceFolder, "PTS"));
                foreach (string file in filePaths)
                {
                    FileInfo info = new FileInfo(file);
                    if (File.Exists(info.FullName))
                    {
                        string fileName = Path.GetFileName(info.FullName);
                        if (!string.IsNullOrEmpty(fileName))
                        {
                            try
                            {
                                File.Copy(info.FullName, System.IO.Path.Combine(destinationFolder, fileName), true);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }
                    }
                }

                // copy DLL
                filePaths = Directory.GetFiles(System.IO.Path.Combine(sourceFolder, "DLL"));
                foreach (string file in filePaths)
                {
                    FileInfo info = new FileInfo(file);
                    if (File.Exists(info.FullName))
                    {
                        string fileName = Path.GetFileName(info.FullName);
                        if (!string.IsNullOrEmpty(fileName))
                        {
                            try
                            {
                                File.Copy(info.FullName, System.IO.Path.Combine(destinationFolder, fileName), true);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }
                    }
                }

                // copy ICON
                filePaths = Directory.GetFiles(System.IO.Path.Combine(sourceFolder, "ICON"));
                foreach (string file in filePaths)
                {
                    FileInfo info = new FileInfo(file);
                    if (File.Exists(info.FullName))
                    {
                        string fileName = Path.GetFileName(info.FullName);
                        if (!string.IsNullOrEmpty(fileName))
                        {
                            try
                            {
                                File.Copy(info.FullName, System.IO.Path.Combine(destinationFolder, fileName), true);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }
                    }
                }

                // copy IMAGE
                filePaths = Directory.GetFiles(System.IO.Path.Combine(sourceFolder, "IMAGE"));
                foreach (string file in filePaths)
                {
                    FileInfo info = new FileInfo(file);
                    if (File.Exists(info.FullName))
                    {
                        string fileName = Path.GetFileName(info.FullName);
                        if (!string.IsNullOrEmpty(fileName))
                        {
                            try
                            {
                                File.Copy(info.FullName, System.IO.Path.Combine(destinationFolder, fileName), true);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }
                    }
                }


                // copy RUN trigger files
                filePaths = Directory.GetFiles(System.IO.Path.Combine(sourceFolder, "RUN", "shm", "comm"));
                string CopyToFolder = System.IO.Path.Combine(destinationFolder, "run", "shm", "comm");
                foreach (string file in filePaths)
                {
                    FileInfo info = new FileInfo(file);
                    if (File.Exists(info.FullName))
                    {
                        string fileName = Path.GetFileName(info.FullName);
                        if (!string.IsNullOrEmpty(fileName))
                        {
                            try
                            {
                                File.Copy(info.FullName, System.IO.Path.Combine(CopyToFolder, fileName), true);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }
                    }
                }

                // copy RUN trigger files
                filePaths = Directory.GetFiles(System.IO.Path.Combine(sourceFolder, "RUN", "shm", "comm_archives"));
                CopyToFolder = System.IO.Path.Combine(destinationFolder, "run", "shm", "comm_archives");
                foreach (string file in filePaths)
                {
                    FileInfo info = new FileInfo(file);
                    if (File.Exists(info.FullName))
                    {
                        string fileName = Path.GetFileName(info.FullName);
                        if (!string.IsNullOrEmpty(fileName))
                        {
                            try
                            {
                                File.Copy(info.FullName, System.IO.Path.Combine(CopyToFolder, fileName), true);
                            }
                            catch (Exception ex)
                            {
                                string strMsg = string.Format("{0}", ex.Message.ToString());
                                MessageBox.Show(strMsg, "Important Message");
                                return false;
                            }
                        }
                    }
                }

                // create PTS desktop shurtcut 
                appShortcutToDesktop("PTS");
            }

            return ok;
        }


        private bool InstallGtkSharpPackage()
        {
            bool ok = true;

            string processFilePath = System.IO.Path.Combine(AppHomeFolder.Trim(), "GTKSHARP", "gtk-sharp.msi");
            if(File.Exists(processFilePath.Trim()))
            {
                try
                {
                    // Use ProcessStartInfo class
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.CreateNoWindow = false;
                    startInfo.UseShellExecute = false;
                    startInfo.FileName = processFilePath;
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    //startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;
                    //using (System.Diagnostics.Process exeProcess = System.Diagnostics.Process.Start(startInfo))
                    using (System.Diagnostics.Process exeProcess = System.Diagnostics.Process.Start(processFilePath))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    ok = false;
                }
            }

            return ok;
        }


        private bool InstallDotNetPackage()
        {
            bool ok = true;

            string processFilePath = System.IO.Path.Combine(AppHomeFolder.Trim(), "DOTNET", "dotNetFx40_Full_setup.exe");
            if (File.Exists(processFilePath.Trim()))
            {
                try
                {
                    // Use ProcessStartInfo class
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.CreateNoWindow = false;
                    startInfo.UseShellExecute = false;
                    startInfo.FileName = processFilePath;
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    //startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;
                    //using (System.Diagnostics.Process exeProcess = System.Diagnostics.Process.Start(startInfo))
                    using (System.Diagnostics.Process exeProcess = System.Diagnostics.Process.Start(processFilePath))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    ok = false;
                }
            }

            return ok;
        }


        private void appShortcutToDesktop(string linkName)
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using (StreamWriter writer = new StreamWriter(deskDir + "\\" + linkName + ".url"))
            {
                // set home folder path
                string HomeFolder = string.Empty;
		        if(IsLinux)
		        {
			        HomeFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal).ToString();
		        }
		        else
		        {
			        DirectoryInfo dirWindowsFolder = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.Windows));
			        //HomeFolder = dirWindowsFolder.Name.ToString();
			        HomeFolder = dirWindowsFolder.Root.Name.ToString();
		        }

                //string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string appFolder = System.IO.Path.Combine(HomeFolder, "Rigaku", "PTS");
                if (Directory.Exists(appFolder))
                {
                    string app = System.IO.Path.Combine(appFolder, "PTS.exe");
                    if (File.Exists(app))
                    {
                        writer.WriteLine("[InternetShortcut]");
                        writer.WriteLine("URL=file:///" + app);
                        writer.WriteLine("IconIndex=0");
                        string icon = app.Replace('\\', '/');
                        writer.WriteLine("IconFile=" + icon);
                        writer.Flush();
                    }
                }
            }
        }

        public bool IsLinux
        {
            get
            {
                int p = (int)Environment.OSVersion.Platform;
                return (p == 4) || (p == 6) || (p == 128);
            }
        }

    }
}
