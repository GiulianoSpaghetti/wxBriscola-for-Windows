using System;
using WixSharp;

namespace wxbriscola_Mazzi_HD_Gatti
{
    internal class Program
    {
        static void Main()
        {
            var project = new Project("wxBriscola-Mazzi-HD-Gatti",
                              new Dir(@"[ProgramFiles64Folder]\\wxBriscola",
                                new Dir("Mazzi",
                                    new Dir("Gatti"),
                                        new DirFiles("*.*")
                                )
                              )
            );

            project.GUID = new Guid("e75784e4-b88d-4bba-9cba-abb313ca4dd4");

            project.Version = new Version("1.4");
            project.Platform = Platform.x64;
            project.SourceBaseDir = "C:\\Users\\numer\\source\\repos\\wxBriscola-for-Windows\\wxbriscola-Mazzi-HD-Gatti\\Gatti";
            project.LicenceFile = "LICENSE.rtf";
            project.ControlPanelInfo.Manufacturer = "Giulio Sorrentino";
            project.ControlPanelInfo.Name = "wxBriscola-Mazzi-HD-Gatti";
            project.ControlPanelInfo.HelpLink = "https://github.com/numerunix/wxBriscola-for-Windows/issues";
            project.Description = "Mazzo di carte home m";
            project.OutDir = "C:\\Users\\numer";
            project.BuildMsi();
        }
    }
}