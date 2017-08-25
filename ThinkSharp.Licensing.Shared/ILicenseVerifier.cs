﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThinkSharp.Licensing;

namespace ThinkSharp
{
    public interface ILicenseVerifier
    {
        /// <summary>
        /// Gets the existing license or null if no license is available
        /// </summary>
        /// <returns>
        /// The <see cref="SignedLicense"/> that represents the license.
        /// </returns>
        /// <exception cref="SignedLicenseException">
        /// Thrown if the existing license is not valid.
        /// </exception>
        SignedLicense GetLicense();
    }
}
