// Type: System.Timers.Timer
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll

using System.ComponentModel;
using System.Runtime;
using System.Security.Permissions;

namespace System.Timers
{
  /// <summary>
  /// Generates recurring events in an application.
  /// </summary>
  [DefaultEvent("Elapsed")]
  [DefaultProperty("Interval")]
  [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true, Synchronization = true)]
  public class Timer : Component, ISupportInitialize
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Timers.Timer"/> class, and sets all the properties to their initial values.
    /// </summary>
    public Timer();
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Timers.Timer"/> class, and sets the <see cref="P:System.Timers.Timer.Interval"/> property to the specified number of milliseconds.
    /// </summary>
    /// <param name="interval">The time, in milliseconds, between events. The value must be greater than zero and less than or equal to <see cref="F:System.Int32.MaxValue"/>.</param><exception cref="T:System.ArgumentException">The value of the <paramref name="interval"/> parameter is less than or equal to zero, or greater than <see cref="F:System.Int32.MaxValue"/>. </exception>
    public Timer(double interval);
    /// <summary>
    /// Begins the run-time initialization of a <see cref="T:System.Timers.Timer"/> that is used on a form or by another component.
    /// </summary>
    public void BeginInit();
    /// <summary>
    /// Releases the resources used by the <see cref="T:System.Timers.Timer"/>.
    /// </summary>
    public void Close();
    /// <summary>
    /// Releases all resources used by the current <see cref="T:System.Timers.Timer"/>.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
    protected override void Dispose(bool disposing);
    /// <summary>
    /// Ends the run-time initialization of a <see cref="T:System.Timers.Timer"/> that is used on a form or by another component.
    /// </summary>
    /// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode"/></PermissionSet>
    public void EndInit();
    /// <summary>
    /// Starts raising the <see cref="E:System.Timers.Timer.Elapsed"/> event by setting <see cref="P:System.Timers.Timer.Enabled"/> to true.
    /// </summary>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The <see cref="T:System.Timers.Timer"/> is created with an interval equal to or greater than <see cref="F:System.Int32.MaxValue"/> + 1, or set to an interval less than zero.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode"/></PermissionSet>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Start();
    /// <summary>
    /// Stops raising the <see cref="E:System.Timers.Timer.Elapsed"/> event by setting <see cref="P:System.Timers.Timer.Enabled"/> to false.
    /// </summary>
    /// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode"/></PermissionSet>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Stop();
    /// <summary>
    /// Gets or sets a value indicating whether the <see cref="T:System.Timers.Timer"/> should raise the <see cref="E:System.Timers.Timer.Elapsed"/> event each time the specified interval elapses or only after the first time it elapses.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="T:System.Timers.Timer"/> should raise the <see cref="E:System.Timers.Timer.Elapsed"/> event each time the interval elapses; false if it should raise the <see cref="E:System.Timers.Timer.Elapsed"/> event only once, after the first time the interval elapses. The default is true.
    /// </returns>
    [Category("Behavior")]
    [TimersDescription("TimerAutoReset")]
    [DefaultValue(true)]
    public bool AutoReset { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether the <see cref="T:System.Timers.Timer"/> should raise the <see cref="E:System.Timers.Timer.Elapsed"/> event.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="T:System.Timers.Timer"/> should raise the <see cref="E:System.Timers.Timer.Elapsed"/> event; otherwise, false. The default is false.
    /// </returns>
    /// <exception cref="T:System.ObjectDisposedException">This property cannot be set because the timer has been disposed.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Timers.Timer.Interval"/> property was set to a value greater than <see cref="F:System.Int32.MaxValue"/> before the timer was enabled. </exception>
    [TimersDescription("TimerEnabled")]
    [Category("Behavior")]
    [DefaultValue(false)]
    public bool Enabled { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }
    /// <summary>
    /// Gets or sets the interval at which to raise the <see cref="E:System.Timers.Timer.Elapsed"/> event.
    /// </summary>
    /// 
    /// <returns>
    /// The time, in milliseconds, between <see cref="E:System.Timers.Timer.Elapsed"/> events. The value must be greater than zero, and less than or equal to <see cref="F:System.Int32.MaxValue"/>. The default is 100 milliseconds.
    /// </returns>
    /// <exception cref="T:System.ArgumentException">The interval is less than or equal to zero.-or-The interval is greater than <see cref="F:System.Int32.MaxValue"/>, and the timer is currently enabled. (If the timer is not currently enabled, no exception is thrown until it becomes enabled.) </exception>
    [DefaultValue(100)]
    [Category("Behavior")]
    [SettingsBindable(true)]
    [TimersDescription("TimerInterval")]
    public double Interval { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }
    /// <summary>
    /// Gets or sets the site that binds the <see cref="T:System.Timers.Timer"/> to its container in design mode.
    /// </summary>
    /// 
    /// <returns>
    /// An <see cref="T:System.ComponentModel.ISite"/> interface representing the site that binds the <see cref="T:System.Timers.Timer"/> object to its container.
    /// </returns>
    public override ISite Site { get; set; }
    /// <summary>
    /// Gets or sets the object used to marshal event-handler calls that are issued when an interval has elapsed.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ComponentModel.ISynchronizeInvoke"/> representing the object used to marshal the event-handler calls that are issued when an interval has elapsed. The default is null.
    /// </returns>
    [DefaultValue(null)]
    [Browsable(false)]
    [TimersDescription("TimerSynchronizingObject")]
    public ISynchronizeInvoke SynchronizingObject { get; [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set; }
    /// <summary>
    /// Occurs when the interval elapses.
    /// </summary>
    [TimersDescription("TimerIntervalElapsed")]
    [Category("Behavior")]
    public event ElapsedEventHandler Elapsed;
  }
}
