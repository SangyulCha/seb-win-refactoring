﻿/*
 * Copyright (c) 2024 ETH Zürich, IT Services
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.Net.Http;

namespace SafeExamBrowser.Proctoring.ScreenProctoring.Service.Requests
{
	internal static class Extensions
	{
		internal static string ToLogString(this HttpResponseMessage response)
		{
			return $"{(int?) response?.StatusCode} {response?.StatusCode} {response?.ReasonPhrase}";
		}

		internal static long ToUnixTimestamp(this DateTime date)
		{
			return new DateTimeOffset(date).ToUnixTimeMilliseconds();
		}
	}
}
