// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// The routes table associated with the ExpressRouteCircuit
    /// </summary>
    public partial class ExpressRouteCircuitRoutesTable
    {
        private string _addressPrefix;
        
        /// <summary>
        /// Optional. Gets AddressPrefix.
        /// </summary>
        public string AddressPrefix
        {
            get { return this._addressPrefix; }
            set { this._addressPrefix = value; }
        }
        
        private string _asPath;
        
        /// <summary>
        /// Optional. Gets AsPath.
        /// </summary>
        public string AsPath
        {
            get { return this._asPath; }
            set { this._asPath = value; }
        }
        
        private string _nextHopIP;
        
        /// <summary>
        /// Optional. Gets NextHopIP.
        /// </summary>
        public string NextHopIP
        {
            get { return this._nextHopIP; }
            set { this._nextHopIP = value; }
        }
        
        private string _nextHopType;
        
        /// <summary>
        /// Required. Gets NextHopType.
        /// </summary>
        public string NextHopType
        {
            get { return this._nextHopType; }
            set { this._nextHopType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitRoutesTable()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class with required arguments.
        /// </summary>
        public ExpressRouteCircuitRoutesTable(string nextHopType)
            : this()
        {
            if (nextHopType == null)
            {
                throw new ArgumentNullException("nextHopType");
            }
            this.NextHopType = nextHopType;
        }
    }
}
