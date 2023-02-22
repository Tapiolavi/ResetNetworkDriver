namespace ResetNetworkDriver.Interfaces
{
    public interface IProgresBarManager
    {
        void Start();
        void Update(int progress, string status);
        void Finish(string message);
    }
}
