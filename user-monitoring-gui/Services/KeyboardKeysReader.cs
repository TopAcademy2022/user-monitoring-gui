using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{

    /*! 
    * @brief Class responsible for reading keyboard key codes.
    */
    public class KeyboardKeysReader : IKeyboardKeysReader
    {

       /*! 
       * @brief Gets the key code of the pressed key.
       * @return Returns the key code of the currently pressed key as a <see cref="uint"/>.If no key is pressed, it returns 0.
       */
        public uint GetKeyCodePressedKey()
        {
            return 0;
        }
    }
}