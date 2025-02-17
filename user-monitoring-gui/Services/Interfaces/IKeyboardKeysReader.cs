namespace user_monitoring_gui.Services.Interfaces
{

    /*! 
     * @brief Interface for reading keyboard key inputs. Gets the key code of the currently pressed key. 
   */
    public interface IKeyboardKeysReader
    {
        public uint GetKeyCodePressedKey();
    }
}