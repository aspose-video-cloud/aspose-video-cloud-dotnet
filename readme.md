![](https://img.shields.io/badge/REST%20API-v1.1-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.video-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.video-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-video-cloud/aspose-video-cloud-dotnet)](https://github.com/aspose-video-cloud/aspose-video-cloud-dotnet/blob/master/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/Aspose-video-Cloud/aspose-video-cloud-dotnet)

# .NET SDK for Video File Formats 

This SDK wraps Aspose.Video REST API, which allows to edit video properties such as FPS, aspect ratio, resolution and Bitrate in the Cloud. Developers can also convert videos to different formats and re-encode videos on demand.

## Inspect, Edit or Convert Videos in the Cloud

- [Convert videos to different formats](https://docs.aspose.cloud/video/convert-video/).
- Re-encode videos with different codecs.
- [Combine several video files](https://docs.aspose.cloud/video/append-video/) into one video.
- Adjust properties including, volume level, FPS, PTS, resolution, Aspect ratio, bitrate, video standard (PAL, NTSC, FILM).
- Add text or image watermark.
- [Extract thumbnail images from video](https://docs.aspose.cloud/video/extract-thumbnail-image/).
- [Extract part of the video](https://docs.aspose.cloud/video/extract-part-of-the-video/).
- [Extract video information](https://docs.aspose.cloud/video/get-video-info/).
- [Add audio to video](https://docs.aspose.cloud/video/add-audio/).

## Supported Video Formats

**Audio Video Interleave** AVI, **Animate Video File** FLV, **iTunes Video** M4V, **MPEG-4** MP4, **Apple QuickTime Movie** MOV, **Windows Media Video** WMV

## Supported Video Codecs

**H.265/MPEG-H HEVC** x265, **H.264/MPEG-4 AVC** x264, QuickTime H.264, DivX Pro Codec, **H.263/MPEG-4 Part 2** DivX Pro Codec, Xvid, **H.262/MPEG-2** x262, **Microsoft codecs** WMV (including WMV 7, WMV 8, and WMV 9), MS MPEG-4v3, **Google (On2)** VP6, VP6-E, VP6-S, VP7, VP8, VP9, libtheora

## Get Started with Aspose.Video Cloud SDK for .NET

Register an account at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) to get you application information. Next, execute `Install-Package Aspose.Video-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.Video Cloud SDK assembly in your project. If you already have Aspose.Video Cloud SDK for .NET, execute `Update-Package Aspose.Video-Cloud` to get the latest version. You may alternatively install the package from command line as `nuget install Aspose.Video-Cloud`.

###  Dependencies

- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## Convert AVI to MP4 in C# .Net

```csharp
	// Get your ClientId and ClientSecret from https://dashboard.aspose.cloud (free registration required).
	
	var videoApi = new OcrApi("MY_CLIENT_SECRET", "MY_CLIENT_ID", "api.aspose.cloud");
	
	ConvertOptions options = new ConvertOptions();
	var request = new PostConvertVideoRequest("original.avi", "mp4", "destination.mp4", options);
	videoApi.PostConvertVideo(request);
```

[Home](https://www.aspose.cloud) | [Product Page](https://products.aspose.cloud/video/net) | [Documentation](https://docs.aspose.cloud/video/) | [API Reference](https://apireference.aspose.cloud/video/) | [Code Samples](https://github.com/aspose-video-cloud/aspose-video-cloud-dotnet/tree/master/Aspose.Video.Cloud.Sdk.Tests) | [Blog](https://blog.aspose.cloud/category/video/) | [Free Support](https://forum.aspose.cloud/c/video) | [Free Trial](https://dashboard.aspose.cloud/#/apps)
