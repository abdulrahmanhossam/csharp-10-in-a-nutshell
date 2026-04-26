namespace CSharp_10_in_a_Nutshell.CP4.Events.YouTubeChannel;

public delegate void VideoUploadedHandler(string videoTitle);
public class YouTubeChannel
{
    public event VideoUploadedHandler OnVideoUploaded;

    public void UploadVideo(string title)
    {
        Console.WriteLine($"[Channel]: Uploading '{title}'...");
        if (OnVideoUploaded != null)
            OnVideoUploaded(title);
    }
}