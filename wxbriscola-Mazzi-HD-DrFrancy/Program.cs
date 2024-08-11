using System;
using WixSharp;

namespace wxbriscola_Mazzi_HD_DrFrancy
{
    internal class Program
    {
            static void Main()
            {
                var project = new Project("wxBriscola-Mazzi-HD-DrFrancy",
                                  new Dir(@"[ProgramFiles64Folder]\\wxBriscola",
                                    new Dir("Mazzi",
                                        new Dir("Dr_Francy"),
                                            new DirFiles("*.*")
                                    )
                                  )
                );

                project.GUID = new Guid("1c4b1377-9057-467f-9349-186985e38d6c");

                project.Version = new Version("1.4");
                project.Platform = Platform.x64;
                project.SourceBaseDir = "C:\\Users\\numer\\source\\repos\\wxBriscola-for-Windows\\wxbriscola-Mazzi-HD-DrFrancy\\Dr_Francy";
                project.LicenceFile = "LICENSE.rtf";
                project.ControlPanelInfo.Manufacturer = "Giulio Sorrentino";
                project.ControlPanelInfo.Name = "wxBriscola-Mazzi-HD-DrFrancy";
                project.ControlPanelInfo.HelpLink = "https://github.com/numerunix/wxBriscola-for-Windows/issues";
                project.Description = "Mazzo di carte home made per il gioco della briscola";
                project.OutDir = "C:\\Users\\numer";
                project.BuildMsi();
            }
        }
    }