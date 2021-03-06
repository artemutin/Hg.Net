// 
//  CommandException.cs
//  
//  Author:
//       Levi Bard <levi@unity3d.com>
//  
//  Copyright (c) 2011 Levi Bard
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace Mercurial
{
	/// <summary>
	/// A mercurial command exception
	/// </summary>
	public class CommandException: Exception
	{
		/// <summary>
		/// Create a new CommandException
		/// </summary>
		/// <param name='message'>
		/// The base exception message
		/// </param>
		internal CommandException (string message):
			base (message)
		{
		}
		
		/// <summary>
		/// Create a new CommandException
		/// </summary>
		/// <param name='message'>
		/// The base exception message
		/// </param>
		/// <param name='innerException'>
		/// The inner exception
		/// </param>
		internal CommandException (string message, Exception innerException):
			base (message, innerException)
		{
		}
		
		/// <summary>
		/// Create a new CommandException
		/// </summary>
		/// <param name='message'>
		/// The base exception message
		/// </param>
		/// <param name='result'>
		/// Include the output and error from this result
		/// </param>
		internal CommandException (string message, CommandResult result):
			this (string.Format ("{0}\n{1}\n{2}", message, result.Error, result.Output))
		{
		}
	}
}

