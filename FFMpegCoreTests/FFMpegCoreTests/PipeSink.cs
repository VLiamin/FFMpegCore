using FFMpegCore.Pipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMpegCoreTests
{
	public class PipeSink : IPipeSink
	{
		public string GetFormat()
		{
			return string.Empty;
		}

		public Task ReadAsync(Stream inputStream, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
