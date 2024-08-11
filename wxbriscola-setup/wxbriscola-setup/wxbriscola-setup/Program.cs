using System;
using WixSharp;

namespace wxbriscola_setup
{
    internal class Program
    {
        static void Main()
        {
            var project = new Project("wxBriscola",
                              new Dir(@"[ProgramFiles64Folder]\wxBriscola",
                                  new File("wxBriscola.exe"),
                                  new File("wxmsw32u_core_vc_colamonico.dll"),
                                  new File("wxbase32u_vc_colamonico.dll"),
                                  new Dir("Mazzi",
                                    new Dir("Napoletano",
                                        new DirFiles(@"Mazzi\Napoletano\*.*")
                                    )
                                  ),
                                  new Dir("locale",
                                      new Dir("en",
                                         new File("locale\\en\\wxbriscola.mo")
                                      ),
                                      new Dir("es",
                                          new File("locale\\es\\wxbriscola.mo"),
                                          new File("locale\\es\\wxstd.mo")
                                      ),
                                      new Dir("fr",
                                          new File("locale\\fr\\wxbriscola.mo"),
                                          new File("locale\\fr\\wxstd.mo")
                                      ),
                                      new Dir("it",
                                          new File("locale\\it\\wxbriscola.mo"),
                                          new File("locale\\it\\wxstd.mo")
                                     )
                                  )
                                  ),
                                  new Dir(@"%ProgramMenu%",
                                  new ExeFileShortcut("wxBriscola", "[ProgramFiles64Folder]\\wxBriscola\\wxBriscola.exe", "") { WorkingDirectory = "[INSTALLDIR]" }
                                  )
                               );

            project.GUID = new Guid("76833DA3-34C1-49B0-A918-8A18257D10FE");
            project.Version = new Version("0.6.3");
            project.Platform = Platform.arm64;
            project.SourceBaseDir = "C:\\Users\\numer\\source\\repos\\wxBriscola\\ARM64\\Release";
            project.LicenceFile = "LICENSE.rtf";
            project.ControlPanelInfo.Manufacturer = "Giulio Sorrentino";
            project.ControlPanelInfo.Name = "wxBriscola";
            project.ControlPanelInfo.HelpLink = "https://github.com/numerunix/wxBriscola-for-Windows/issues";
            project.Description = "Simulatore del gioco della briscola a due giocatori senza multiplayer";
            project.OutDir = "C:\\Users\\numer";

            project.BuildMsi();
        }
    }
}