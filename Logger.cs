using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PyllaBot
{
    internal enum LogLevel
    {
        Critical, Error, Warning, Info, Trace
    }
    internal static class Logger
    {
        public static List<string> logs = new List<string>();
        public static LogLevel LogLevel;

        /*
         * $i = log count
         * $loglvl = log's loglevel
         * $time = utc time
         * $ltime = local time
         * $_time = long utc time
         * $_ltime = long local time
         * $date = utc date
         * $ldate = local date
         * $_date = long utc date
         * $_ldate = long local date
         * $thread_id = thread id
         * $msg = msg
         * 
         */
        public static string Format = "($i)[$loglvl] [$ltime - $date][id:$thread_id][$class][$method]: $msg";
        public static void Log(string msg, LogLevel logLevel)
        {
            StackTrace stack = new StackTrace();
            var method = stack.GetFrame(1).GetMethod();
            var methodClass = method.DeclaringType;
            msg = Format
                        .Replace("$i", logs.Count.ToString())
                        .Replace("$loglevel", logLevel.ToString())
                        .Replace("$time", DateTime.UtcNow.ToShortTimeString())
                        .Replace("$ltime", DateTime.Now.ToShortTimeString())
                        .Replace("$_time", DateTime.UtcNow.ToLongTimeString())
                        .Replace("$_ltime", DateTime.Now.ToLongTimeString())
                        .Replace("$date", DateTime.UtcNow.ToShortDateString())
                        .Replace("$ldate", DateTime.Now.ToShortDateString())
                        .Replace("$_date", DateTime.UtcNow.ToLongDateString())
                        .Replace("$_ldate", DateTime.Now.ToLongDateString())
                        .Replace("$thread_id", Thread.CurrentThread.ManagedThreadId.ToString())
                        .Replace("$loglevel", logLevel.ToString())
                        .Replace("$class", 
                        $"{(methodClass.IsPublic ? "public " : string.Empty)}" +
                        $"{(methodClass.IsNotPublic ? "private " : string.Empty)}" +
                        $"{(methodClass.IsSealed ? "sealed " : string.Empty)}" +
                        $"{(methodClass.IsClass ? "class " : string.Empty)}" +
                        $"{(methodClass.IsInterface ? "interface " : string.Empty)}{(methodClass.IsValueType ? "struct " : string.Empty)}" +
                        $"{methodClass.FullName}" +
                        $"{(methodClass.GenericTypeArguments.Length > 0 ? (methodClass.GenericTypeArguments.aggregate((str, t) => $"{str}, {t.FullName}").Remove(0, 2)) : string.Empty)}")
                        .Replace("$method", $"{(method.IsPublic ? "public " : string.Empty)}" +
                        $"{(method.IsPrivate ? "private " : string.Empty)}" +
                        $"{(method.IsFamily ? "protected " : string.Empty)}" +
                        $"{(method.IsVirtual ? "virtual " : string.Empty)}" +
                        $"{(method.IsStatic ? "static " : string.Empty)}" +
                        $"{(method.IsConstructor ? methodClass : (method as MethodInfo).ReturnType) + " "}" +
                        $"{method.Name}({method.GetParameters().aggregate((str, parameter) => $"{str}, {(parameter.IsOut ? "out " : string.Empty)}" +
                        $"{(parameter.IsIn ? "in " : string.Empty)}{parameter.ParameterType} {parameter.Name}").Remove(0, 2)})")
                        .Replace("$msg", msg)
                        + "\n";
            lock (logs)
                logs.Add(msg);
            if (Form1.logForm != null)
            {
                lock (Form1.logForm.logs.Text)
                    Form1.logForm.logs.Text += msg;
            }
        }

        public static async Task LogAsync(string msg, LogLevel logLevel)
        {
            StackTrace stack = new StackTrace();
            var method = stack.GetFrame(1).GetMethod();
            var methodClass = method.DeclaringType;
            msg = Format
                        .Replace("$i", logs.Count.ToString())
                        .Replace("$loglevel", logLevel.ToString())
                        .Replace("$time", DateTime.UtcNow.ToShortTimeString())
                        .Replace("$ltime", DateTime.Now.ToShortTimeString())
                        .Replace("$_time", DateTime.UtcNow.ToLongTimeString())
                        .Replace("$_ltime", DateTime.Now.ToLongTimeString())
                        .Replace("$date", DateTime.UtcNow.ToShortDateString())
                        .Replace("$ldate", DateTime.Now.ToShortDateString())
                        .Replace("$_date", DateTime.UtcNow.ToLongDateString())
                        .Replace("$_ldate", DateTime.Now.ToLongDateString())
                        .Replace("$thread_id", Thread.CurrentThread.ManagedThreadId.ToString())
                        .Replace("$loglevel", logLevel.ToString())
                        .Replace("$class", $"{(methodClass.IsPublic ? "public " : string.Empty)}{(methodClass.IsNotPublic ? "private " : string.Empty)}{(methodClass.IsSealed ? "sealed " : string.Empty)}{(methodClass.IsClass ? "class " : string.Empty)}{(methodClass.IsInterface ? "interface " : string.Empty)}{(methodClass.IsValueType ? "struct " : string.Empty)}{methodClass.FullName}{(methodClass.GenericTypeArguments.Length > 0 ? methodClass.GenericTypeArguments.aggregate((str, t) => $"{str}, {t.FullName}").Remove(1, 2).Insert(0, "<") + ">" : string.Empty)}")
                        .Replace("$method", $"{(method.IsPublic ? "public " : string.Empty)}{(method.IsPrivate ? "private " : string.Empty)}{(method.IsFamily ? "protected " : string.Empty)}{(method.IsVirtual ? "virtual " : string.Empty)}{(method.IsStatic ? "static " : string.Empty)}{(method.IsConstructor ? methodClass : (method as MethodInfo).ReturnType) + " "}{method.Name}({method.GetParameters().aggregate((str, parameter) => $"{str}, {(parameter.IsOut ? "out " : string.Empty)}{(parameter.IsIn ? "in " : string.Empty)}{parameter.ParameterType} {parameter.Name}").Remove(0, 2)})")
                        .Replace("$msg", msg)
                        + "\n";
            lock (logs)
                logs.Add(msg);
            if (Form1.logForm != null)
            {
                lock (Form1.logForm.logs.Text)
                    Form1.logForm.logs.Text += msg;
            }
        }

        private static string aggregate<T>(this T[] array, Func<string, T, string> func)
        {
            string final = string.Empty;
            foreach (T item in array)
            {
                final = func(final, item);
            }
            return final;
        }
    }
}
