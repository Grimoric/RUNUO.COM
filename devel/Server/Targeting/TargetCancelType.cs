/***************************************************************************
 *                            TargetCancelType.cs
 *                            -------------------
 *   begin                : May 1, 2002
 *   copyright            : (C) The RunUO Software Team
 *   email                : info@runuo.com
 *
 *   $Id: TargetCancelType.cs 20 2006-01-15 23:50:35Z asayre $
 *
 ***************************************************************************/

/***************************************************************************
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 2 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/

using System;

namespace Server.Targeting
{
	public enum TargetCancelType
	{
		Overriden,
		Canceled,
		Disconnected,
		Timeout
	}
}