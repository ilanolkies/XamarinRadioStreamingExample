using System.Threading.Tasks;

namespace StreamingExample
{
    public interface IStreaming
    {
		void Play();
		void Pause();
		void Stop();
    }
}
