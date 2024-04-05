using user_monitoring_gui.Models.Network;

namespace user_monitoring_gui.Services.Interfaces
{       
	/*!
	 * @brief Public interfaceinterface request from the serverrequest from the server
	 */
	public interface IServerRequest
    {
     /*!
      * @brief  public method ServerResponse SendData
      * @param transmits an array of bytes of data  
      * @return ServerResponse
      */
        public ServerResponse SendData(byte[] data);
	}
}