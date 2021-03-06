﻿using System;
using System.Runtime.Serialization;

namespace Squishy.Irc
{
	public class IrcException : Exception
	{
		protected IrcException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public IrcException(string message)
			: base(message)
		{
		}

		public IrcException(string message,
			params object[] args)
			: base(string.Format(message, args))
		{
		}

		public IrcException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public IrcException()
		{
		}
	}
}
