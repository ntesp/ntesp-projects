using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntesp.Utils {
    public class Program {
        static readonly string defaultinput = "{0} v{1}.{2}.{3}.{4} {5}\r\n";
        static readonly Assembly assembly = Assembly.GetExecutingAssembly();

        static void Main(string[] Arguments) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            for (int i = 0; i < Arguments.Length; i++) {
                string argument = Arguments[i];
                switch (argument) {
                    case "-v":
                    case "--version":
                        Version();
                        break;
                    case "-u":
                    case "--usage":
                    default:
                        Usage();
                        break;
                }
            }
            Console.WriteLine("");
        }

        private static void Usage() {
            Console.WriteLine(defaultinput + "usage: {0} [options] argument\r\noption(s):\r\n-v, --version: {6}\r\n-u, --usage: {7}\r\nto see Details, access \"(https://)ntesp.github.io/ntesp-projects/docs/ntesp.Utils/details\".", assembly.GetName().Name,
                assembly.GetName().Version.Major, assembly.GetName().Version.Minor,
                assembly.GetName().Version.Build, assembly.GetName().Version.Revision,
                "Copyright 2023 ~; All rights reserved.", "Display application's version.", "Display this message, details to use.");
        }

        static void Version() {

            Console.WriteLine(defaultinput, assembly.GetName().Name,
                assembly.GetName().Version.Major, assembly.GetName().Version.Minor,
                assembly.GetName().Version.Build, assembly.GetName().Version.Revision,
                "Copyright 2023 ~; All rights reserved.");
        }
    }
}
