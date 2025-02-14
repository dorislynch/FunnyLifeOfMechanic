using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Funny.Life.Of.Mechanic.RNFunnyLifeOfMechanic
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNFunnyLifeOfMechanicModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNFunnyLifeOfMechanicModule"/>.
        /// </summary>
        internal RNFunnyLifeOfMechanicModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNFunnyLifeOfMechanic";
            }
        }
    }
}
