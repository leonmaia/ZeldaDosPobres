// Type: System.Windows.Forms.KeyPressEventArgs
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using System;
using System.Runtime;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
  /// <summary>
  /// Provides data for the <see cref="E:System.Windows.Forms.Control.KeyPress"/> event.
  /// </summary>
  /// <filterpriority>2</filterpriority>
  [ComVisible(true)]
  public class KeyPressEventArgs : EventArgs
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Windows.Forms.KeyPressEventArgs"/> class.
    /// </summary>
    /// <param name="keyChar">The ASCII character corresponding to the key the user pressed. </param>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public KeyPressEventArgs(char keyChar);
    /// <summary>
    /// Gets or sets the character corresponding to the key pressed.
    /// </summary>
    /// 
    /// <returns>
    /// The ASCII character that is composed. For example, if the user presses SHIFT + K, this property returns an uppercase K.
    /// </returns>
    /// <filterpriority>1</filterpriority>
    public char KeyChar { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set; }
    /// <summary>
    /// Gets or sets a value indicating whether the <see cref="E:System.Windows.Forms.Control.KeyPress"/> event was handled.
    /// </summary>
    /// 
    /// <returns>
    /// true if the event is handled; otherwise, false.
    /// </returns>
    /// <filterpriority>1</filterpriority>
    public bool Handled { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set; }
  }
}
