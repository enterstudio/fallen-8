// 
//  RangeScanSpecification.cs
//  
//  Author:
//       Henning Rauch <Henning@RauchEntwicklung.biz>
//  
//  Copyright (c) 2012 Henning Rauch
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

#region Usings

using System;
using System.Runtime.Serialization;

#endregion

namespace NoSQL.GraphDB.Service.REST.Specification
{
	/// <summary>
    ///   The range scan specification
    /// </summary>
    [DataContract]
    public sealed class RangeScanSpecification
    {
        /// <summary>
        ///   Left limit
        /// </summary>
        [DataMember(IsRequired = true)]
        public String LeftLimit { get; set; }

        /// <summary>
        ///   Right limit
        /// </summary>
        [DataMember(IsRequired = true)]
        public String RightLimit { get; set; }

        /// <summary>
        ///   The type of the literals
        /// </summary>
        [DataMember(IsRequired = true)]
        public String FullQualifiedTypeName { get; set; }

        /// <summary>
        ///   Include left limit
        /// </summary>
        [DataMember]
        public Boolean IncludeLeft { get; set; }

        /// <summary>
        ///   Include right limit
        /// </summary>
        [DataMember]
        public Boolean IncludeRight { get; set; }

        /// <summary>
        ///   Result type specification
        /// </summary>
        [DataMember(IsRequired = true)]
        public ResultTypeSpecification ResultType { get; set; }
    }
}

