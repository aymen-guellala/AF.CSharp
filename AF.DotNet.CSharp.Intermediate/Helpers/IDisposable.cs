using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Intermediate.Helpers
{
    public class IDisposableHelper
    {
        // Design pattern for a base class.
        public abstract class Base : IDisposable
        {
            private bool disposed = false;
            private string instanceName;
            private List<object> trackingList;

            public Base(string instanceName, List<object> tracking)
            {
                this.instanceName = instanceName;
                trackingList = tracking;
                trackingList.Add(this);
            }

            public string InstanceName
            {
                get
                {
                    return instanceName;
                }
            }

            //Implement IDisposable.
            public void Dispose()
            {
                Console.WriteLine("\n[{0}].Base.Dispose()", instanceName);
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        // Free other state (managed objects).
                        Console.WriteLine("[{0}].Base.Dispose(true)", instanceName);
                        trackingList.Remove(this);
                        Console.WriteLine("[{0}] Removed from tracking list: {1:x16}",
                            instanceName, this.GetHashCode());
                    }
                    else
                    {
                        Console.WriteLine("[{0}].Base.Dispose(false)", instanceName);
                    }
                    disposed = true;
                }
            }

            // Use C# destructor syntax for finalization code.
            ~Base()
            {
                // Simply call Dispose(false).
                Console.WriteLine("\n[{0}].Base.Finalize()", instanceName);
                Dispose(false);
            }
        }

        // Design pattern for a derived class.
        public class Derived : Base
        {
            private bool disposed = false;
            private IntPtr umResource;

            public Derived(string instanceName, List<object> tracking) :
                base(instanceName, tracking)
            {
                // Save the instance name as an unmanaged resource
                umResource = Marshal.StringToCoTaskMemAuto(instanceName);
            }

            protected override void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        Console.WriteLine("[{0}].Derived.Dispose(true)", InstanceName);
                        // Release managed resources.
                    }
                    else
                    {
                        Console.WriteLine("[{0}].Derived.Dispose(false)", InstanceName);
                    }
                    // Release unmanaged resources.
                    if (umResource != IntPtr.Zero)
                    {
                        Marshal.FreeCoTaskMem(umResource);
                        Console.WriteLine("[{0}] Unmanaged memory freed at {1:x16}",
                            InstanceName, umResource.ToInt64());
                        umResource = IntPtr.Zero;
                    }
                    disposed = true;
                }
                // Call Dispose in the base class.
                base.Dispose(disposing);
            }
            // The derived class does not have a Finalize method
            // or a Dispose method without parameters because it inherits
            // them from the base class.
        }
        
        public static void Run()
        {
            List<object> tracking = new List<object>();

            // Dispose is not called, Finalize will be called later.
            using (null)
            {
                Console.WriteLine("\nDisposal Scenario: #1\n");
                Derived d3 = new Derived("d1", tracking);
            }

            // Dispose is implicitly called in the scope of the using statement.
            using (Derived d1 = new Derived("d2", tracking))
            {
                Console.WriteLine("\nDisposal Scenario: #2\n");
            }

            // Dispose is explicitly called.
            using (null)
            {
                Console.WriteLine("\nDisposal Scenario: #3\n");
                Derived d2 = new Derived("d3", tracking);
                d2.Dispose();
            }

            // Again, Dispose is not called, Finalize will be called later.
            using (null)
            {
                Console.WriteLine("\nDisposal Scenario: #4\n");
                Derived d4 = new Derived("d4", tracking);
            }

            // List the objects remaining to dispose.
            Console.WriteLine("\nObjects remaining to dispose = {0:d}", tracking.Count);
            foreach (Derived dd in tracking)
            {
                Console.WriteLine("    Reference Object: {0:s}, {1:x16}",
                    dd.InstanceName, dd.GetHashCode());
            }

            // Queued finalizers will be exeucted when Main() goes out of scope.
            Console.WriteLine("\nDequeueing finalizers...");
        }
    }
}
