﻿// Copyright 2007-2014 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.RabbitMqTransport
{
    /// <summary>
    /// With a connect, and a model from RabbitMQ, this context is passed forward to allow
    /// the model to be configured and connected
    /// </summary>
    public interface ModelContext :
        PipeContext
    {
        /// <summary>
        /// The model
        /// </summary>
        IHaModel Model { get; }

        /// <summary>
        /// The connection context on which the model was created
        /// </summary>
        ConnectionContext ConnectionContext { get; }
    }
}