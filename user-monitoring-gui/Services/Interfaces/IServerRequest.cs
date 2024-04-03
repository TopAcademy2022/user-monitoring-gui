using user_monitoring_gui.Models.Network;

namespace user_monitoring_gui.Services.Interfaces
{
    public interface IServerRequest
    {
        public ServerResponse SendData(byte[] data);
    }
}