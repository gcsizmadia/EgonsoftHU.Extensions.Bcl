﻿// Copyright © 2022-2023 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Reflection;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="ParameterInfo"/> type.
    /// </summary>
    public static class ParameterInfoExtensions
    {
        /// <summary>
        /// Indicates whether a parameter has the specified type.
        /// </summary>
        /// <typeparam name="TParameterType">The expected parameter type.</typeparam>
        /// <param name="parameter">The parameter to test.</param>
        /// <returns>true if parameter type meets the expectation; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="parameter"/> is <see langword="null"/>.</exception>
        public static bool Is<TParameterType>(this ParameterInfo parameter)
        {
            return parameter.Is(typeof(TParameterType));
        }

        /// <summary>
        /// Indicates whether a parameter has the specified type.
        /// </summary>
        /// <param name="parameter">The parameter to test.</param>
        /// <param name="parameterType">The expected type of the parameter.</param>
        /// <returns>true if parameter type meets the expectation; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">
        /// Either <paramref name="parameter"/> or <paramref name="parameterType"/> is <see langword="null"/>.
        /// </exception>
        public static bool Is(this ParameterInfo parameter, Type parameterType)
        {
            parameter.ThrowIfNull();
            parameterType.ThrowIfNull();

            return parameterType == parameter.ParameterType;
        }

        /// <summary>
        /// Indicates whether a parameter has the specified type and name.
        /// </summary>
        /// <typeparam name="TParameterType">The expected parameter type.</typeparam>
        /// <param name="parameter">The parameter to test.</param>
        /// <param name="parameterName">The expected name of the parameter.</param>
        /// <returns>true if parameter type and name meet the expectations; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">
        /// Either <paramref name="parameter"/> is <see langword="null"/>
        /// or <paramref name="parameterName"/> is <see langword="null"/>, <see cref="String.Empty"/> or consists only of white-space characters.
        /// </exception>
        public static bool Is<TParameterType>(this ParameterInfo parameter, string parameterName)
        {
            return parameter.Is(typeof(TParameterType), parameterName);
        }

        /// <summary>
        /// Indicates whether a parameter has the specified type and name.
        /// </summary>
        /// <param name="parameter">The parameter to test.</param>
        /// <param name="parameterType">The expected type of the parameter.</param>
        /// <param name="parameterName">The expected name of the parameter.</param>
        /// <returns>true if parameter type and name meet the expectations; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">
        /// Either <paramref name="parameter"/> or <paramref name="parameterType"/> is <see langword="null"/>
        /// or <paramref name="parameterName"/> is <see langword="null"/>, <see cref="String.Empty"/> or consists only of white-space characters.
        /// </exception>
        public static bool Is(this ParameterInfo parameter, Type parameterType, string parameterName)
        {
            parameter.ThrowIfNull();
            parameterType.ThrowIfNull();
            parameterName.ThrowIfNullOrWhiteSpace();

            return
                parameterType == parameter.ParameterType
                &&
                String.Equals(parameterName, parameter.Name, StringComparison.Ordinal);
        }
    }
}
