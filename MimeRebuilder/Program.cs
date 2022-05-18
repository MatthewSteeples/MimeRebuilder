using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeRebuilder;

namespace MimeTypesFull
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MimeTypes.TryGetMimeType(args[0], out var mimeType);
		}
	}
}
