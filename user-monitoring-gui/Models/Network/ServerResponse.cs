namespace user_monitoring_gui.Models.Network
{
    public class ServerResponse
    {
        private byte[]? _responseData;

        private ServerStatusCode _statusCode;

        public byte[]? GetData()
        {
            return this._responseData;
        }

        public ServerStatusCode GetServerStatusCode()
        {
            return this._statusCode;
        }
    }
}