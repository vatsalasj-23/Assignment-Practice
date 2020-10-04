using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CreateDirectory
{
	class Directory
	{
		static void Main(string[] args)
		{
			var currentDirectory = System.IO.Directory.GetCurrentDirectory();
			Console.WriteLine(currentDirectory);
			Console.WriteLine(System.IO.Directory.GetDirectoryRoot(currentDirectory));

			Console.ReadLine();

			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var directoryName = $@"{documentPath}/kaumudi ";

			DirectoryInfo dinfo = System.IO.Directory.CreateDirectory(directoryName);
			Console.WriteLine($"complete name of the directory : {dinfo.FullName},Name:{dinfo.Name},Parent:{dinfo.Name}");
			Console.ReadLine();


		}
	}
}
