// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KSeFAPI.Models
{
    /// <summary> The File1MBHashType. </summary>
    public partial class File1MBHashType
    {
        /// <summary> Initializes a new instance of File1MBHashType. </summary>
        /// <param name="hashSHA"></param>
        /// <param name="fileSize"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="hashSHA"/> is null. </exception>
        public File1MBHashType(HashSHAType hashSHA, int fileSize)
        {
            if (hashSHA == null)
            {
                throw new ArgumentNullException(nameof(hashSHA));
            }

            HashSHA = hashSHA;
            FileSize = fileSize;
        }

        /// <summary> Gets the hash sha. </summary>
        public HashSHAType HashSHA { get; }
        /// <summary> Gets the file size. </summary>
        public int FileSize { get; }
    }
}
