﻿//------------------------------------------------------------------------------
// <copyright file="IVsPackageWrapper.cs" company="Aras Corporation">
//     © 2017-2019 Aras Corporation. All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Aras.VS.MethodPlugin
{
	public interface IVsPackageWrapper
	{
		object GetGlobalService(Type type);
	}
}
