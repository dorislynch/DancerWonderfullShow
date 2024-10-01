using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Dancer.Wonderfull.Show.RNDancerWonderfullShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDancerWonderfullShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDancerWonderfullShowModule"/>.
        /// </summary>
        internal RNDancerWonderfullShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDancerWonderfullShow";
            }
        }
    }
}
