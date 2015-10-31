using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tw.moa.csharp.MoaLog
{
    public class MoaLog
    {
        public static void Info(
            string msg,
        [CallerMemberName] string callingMethod = null,
        [CallerFilePath] string callingFilePath = null,
        [CallerLineNumber] int callingFileLineNumber = 0)
        {
            string[] path = callingFilePath.Split(new char[] { '\\' });
            Console.WriteLine("[{0,30} : {1,5}  {2}]:::{3}", path.Last<string>(), callingFileLineNumber, callingMethod, msg);
        }

        public static void Debug(
            string msg,
        [CallerMemberName] string callingMethod = null,
        [CallerFilePath] string callingFilePath = null,
        [CallerLineNumber] int callingFileLineNumber = 0)
        {
            //#if DEBUG
            string[] path = callingFilePath.Split(new char[] { '\\' });
            Console.WriteLine("[{0,30} : {1,5}  {2}]:::{3}", path.Last<string>(), callingFileLineNumber, callingMethod, msg);
            //#endif
        }

        public static void Warn(
            string msg,
        [CallerMemberName] string callingMethod = null,
        [CallerFilePath] string callingFilePath = null,
        [CallerLineNumber] int callingFileLineNumber = 0)
        {
            string[] path = callingFilePath.Split(new char[] { '\\' });
            Console.WriteLine("[{0,30} : {1,5}  {2}]:::{3}", path.Last<string>(), callingFileLineNumber, callingMethod, msg);
        }
        public static void Error(
            string msg,
        [CallerMemberName] string callingMethod = null,
        [CallerFilePath] string callingFilePath = null,
        [CallerLineNumber] int callingFileLineNumber = 0)
        {
            string[] path = callingFilePath.Split(new char[] { '\\' });
            Console.WriteLine("[{0,30} : {1,5}  {2}]:::{3}", path.Last<string>(), callingFileLineNumber, callingMethod, msg);
        }
    }
}
