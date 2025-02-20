using user_monitoring_gui.Models.Network;
namespace user_monitoring_gui.Services.Interfaces
{
    public interface IServerRequest
    {
        /*! 
        * @brief Interface for handling server requests. Sends data to the server.
        * @param[in] A byte array containing the data to be sent.
        * @return A byte array containing the data to be sent.
        */
        public ServerResponse SendData(byte[] data);

        /*! 
        * @brief Interface for handling server requests. Loads data from the server.
        * @param[in] The type of the class to be loaded.
        * @return A server response containing the loaded data.
        */
        public ServerResponse LoadData(Type loadedClass);
    }
}