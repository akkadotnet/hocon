﻿//-----------------------------------------------------------------------
// <copyright file="HoconLiteral.cs" company="Hocon Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/hocon>
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Hocon
{
    /// <summary>
    /// This class represents a string literal element in a HOCON (Human-Optimized Config Object Notation)
    /// configuration string.
    /// <code>
    /// akka {  
    ///   actor {
    ///     provider = "Akka.Remote.RemoteActorRefProvider, Akka.Remote"
    ///   }
    /// }
    /// </code>
    /// </summary>
    public class HoconLiteral : IHoconElement
    {
        public HoconLiteral(IHoconElement owner)
        {
            Owner = owner;
        }

        public IHoconElement Owner { get; }

        public bool IsObject()
        {
            return false;
        }

        public HoconObject GetObject()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether this element is a string and all of its characters are whitespace characters.
        /// </summary>
        /// <returns><c>true</c> if every characters in value is whitespace characters; otherwise <c>false</c>.</returns>
        public bool IsWhitespace()
        {
            return Value != null && Value.All(c => StringUtil.Whitespaces.Contains(c));
        }

        /// <summary>
        /// Gets or sets the value of this element.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Determines whether this element is a string.
        /// </summary>
        /// <returns><c>true</c></returns>
        public bool IsString()
        {
            return true;
        }

        /// <summary>
        /// Retrieves the string representation of this element.
        /// </summary>
        /// <returns>The value of this element.</returns>
        public string GetString()
        {
            return Value;
        }

        /// <summary>
        /// Determines whether this element is an array.
        /// </summary>
        /// <returns><c>false</c></returns>
        public bool IsArray()
        {
            return false;
        }

        /// <summary>
        /// Retrieves a list of elements associated with this element.
        /// </summary>
        /// <returns>
        /// A list of elements associated with this element.
        /// </returns>
        /// <exception cref="System.NotImplementedException">
        /// This element is a string literal. It is not an array.
        /// Therefore this method will throw an exception.
        /// </exception>
        public IList<HoconValue> GetArray()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Returns the string representation of this element.
        /// </summary>
        /// <returns>The value of this element.</returns>
        public override string ToString()
        {
            return Value;
        }
    }
}

