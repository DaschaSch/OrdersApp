﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OrdersApp
{
    public static class ExportDataToCsv
    {

            public static void ExportCsv<T>(List<T> genericList, string fileName)
            {
                var sb = new StringBuilder();
                var basePath = "C://Users//dshishko//Desktop//ITMO//OrdersApp//";
                var finalPath = basePath + fileName + ".csv";
               // var header = "";
                var info = typeof(T).GetProperties();
                //if (!File.Exists(finalPath))
                //{
                //    var file = File.Create(finalPath);
                //    file.Close();
                //    foreach (var prop in typeof(T).GetProperties())
                //    {
                //        header += prop.Name + "; ";
                //    }
                //    header = header.Substring(0, header.Length - 2);
                //    sb.AppendLine(header);
                //    TextWriter sw = new StreamWriter(finalPath, true);
                //    sw.Write(sb.ToString());
                //    sw.Close();
                //}
                foreach (var obj in genericList)
                {
                    sb = new StringBuilder();
                    var line = "";
                    foreach (var prop in info)
                    {
                        line += prop.GetValue(obj, null) + "; ";
                    }
                    line = line.Substring(0, line.Length - 2);
                    sb.AppendLine(line);
                    TextWriter sw = new StreamWriter(finalPath, true);
                    sw.Write(sb.ToString());
                    sw.Close();
                }
            }
        }
}
