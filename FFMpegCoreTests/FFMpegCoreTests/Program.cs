using FFMpegCore.Pipes;
using FFMpegCore;
using System.Reflection;
using FFMpegCore.Enums;
using System.Security.Cryptography;

namespace FFMpegCoreTests
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			program.Convert();
		}

		public async void Convert()
		{
			string FilePath = "audio1.mp3";
			string FilePath2 = "audio2.mp4";
			Stream outputStream = new MemoryStream();

			var arg = FFMpegArguments
	.FromFileInput(FilePath)
	.OutputToFile(FilePath2, true, options => options
		.WithVideoCodec(VideoCodec.LibX264)
		.WithConstantRateFactor(21)
		.WithAudioCodec(AudioCodec.Aac)
		.WithVariableBitrate(4)
		.WithVideoFilters(filterOptions => filterOptions.Scale(VideoSize.FullHd))
		.WithFastStart())
	.ProcessSynchronously();
			/*			var mysink = new PipeSink();
						FFMpegArguments.FromFileInput(FilePath)
							.OutputToPipe(mysink).ProcessSynchronously();*/

			var t = 1;
		}
	}
}
