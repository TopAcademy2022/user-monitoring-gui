using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{/*!
  * @brief Public class for Reading a button press on the keyboard
  */
    public class KeyboardKeysReader : IKeyboardKeysReader
    {
        public uint GetKeyCodePressedKey()        
        {
           /*!
            * @brief Gets the key code when it is pressed
            * @param Doesn't have
            * @return the result is 0
            */
            return 0;
        }
    }
}