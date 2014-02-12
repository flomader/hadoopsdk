﻿// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.
namespace Microsoft.Hadoop.Avro.Container
{
    using System;
    using System.Diagnostics.Contracts;
    using System.IO;

    /// <summary>
    ///     No-compression codec.
    /// </summary>
    internal sealed class NullCodec : Codec
    {
        public static readonly string CodecName = "null";

        /// <summary>
        ///     Initializes a new instance of the <see cref="NullCodec" /> class.
        /// </summary>
        public NullCodec() : base(CodecName)
        {
        }

        public override Stream GetCompressedStreamOver(Stream decompressed)
        {
            if (decompressed == null)
            {
                throw new ArgumentNullException("decompressed");
            }
            Contract.EndContractBlock();

            return decompressed;
        }

        public override Stream GetDecompressedStreamOver(Stream compressed)
        {
            if (compressed == null)
            {
                throw new ArgumentNullException("compressed");
            }
            Contract.EndContractBlock();

            return compressed;
        }
    }
}