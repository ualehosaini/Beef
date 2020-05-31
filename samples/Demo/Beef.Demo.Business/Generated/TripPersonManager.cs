/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Entities;
using Beef.Validation;
using Beef.Demo.Common.Entities;
using Beef.Demo.Business.DataSvc;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business
{
    /// <summary>
    /// Provides the TripPerson business functionality.
    /// </summary>
    public partial class TripPersonManager : ITripPersonManager
    {
        #region Private
        #pragma warning disable CS0649 // Defaults to null by design; can be overridden in constructor.

        private readonly Func<string?, Task>? _getOnPreValidateAsync;
        private readonly Action<MultiValidator, string?>? _getOnValidate;
        private readonly Func<string?, Task>? _getOnBeforeAsync;
        private readonly Func<TripPerson?, string?, Task>? _getOnAfterAsync;

        private readonly Func<TripPerson, Task>? _createOnPreValidateAsync;
        private readonly Action<MultiValidator, TripPerson>? _createOnValidate;
        private readonly Func<TripPerson, Task>? _createOnBeforeAsync;
        private readonly Func<TripPerson, Task>? _createOnAfterAsync;

        private readonly Func<TripPerson, string?, Task>? _updateOnPreValidateAsync;
        private readonly Action<MultiValidator, TripPerson, string?>? _updateOnValidate;
        private readonly Func<TripPerson, string?, Task>? _updateOnBeforeAsync;
        private readonly Func<TripPerson, string?, Task>? _updateOnAfterAsync;

        private readonly Func<string?, Task>? _deleteOnPreValidateAsync;
        private readonly Action<MultiValidator, string?>? _deleteOnValidate;
        private readonly Func<string?, Task>? _deleteOnBeforeAsync;
        private readonly Func<string?, Task>? _deleteOnAfterAsync;

        #pragma warning restore CS0649
        #endregion

        /// <summary>
        /// Gets the <see cref="TripPerson"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <returns>The selected <see cref="TripPerson"/> object where found; otherwise, <c>null</c>.</returns>
        public Task<TripPerson?> GetAsync(string? id)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Read;
                EntityBase.CleanUp(id);
                if (_getOnPreValidateAsync != null) await _getOnPreValidateAsync(id).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(id.Validate(nameof(id)).Mandatory())
                    .Additional((__mv) => _getOnValidate?.Invoke(__mv, id))
                    .Run().ThrowOnError();

                if (_getOnBeforeAsync != null) await _getOnBeforeAsync(id).ConfigureAwait(false);
                var __result = await TripPersonDataSvc.GetAsync(id).ConfigureAwait(false);
                if (_getOnAfterAsync != null) await _getOnAfterAsync(__result, id).ConfigureAwait(false);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Creates the <see cref="TripPerson"/> object.
        /// </summary>
        /// <param name="value">The <see cref="TripPerson"/> object.</param>
        /// <returns>A refreshed <see cref="TripPerson"/> object.</returns>
        public Task<TripPerson> CreateAsync(TripPerson value)
        {
            value.Validate(nameof(value)).Mandatory().Run().ThrowOnError();

            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Create;
                EntityBase.CleanUp(value);
                if (_createOnPreValidateAsync != null) await _createOnPreValidateAsync(value).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(value.Validate(nameof(value)))
                    .Additional((__mv) => _createOnValidate?.Invoke(__mv, value))
                    .Run().ThrowOnError();

                if (_createOnBeforeAsync != null) await _createOnBeforeAsync(value).ConfigureAwait(false);
                var __result = await TripPersonDataSvc.CreateAsync(value).ConfigureAwait(false);
                if (_createOnAfterAsync != null) await _createOnAfterAsync(__result).ConfigureAwait(false);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Updates the <see cref="TripPerson"/> object.
        /// </summary>
        /// <param name="value">The <see cref="TripPerson"/> object.</param>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <returns>A refreshed <see cref="TripPerson"/> object.</returns>
        public Task<TripPerson> UpdateAsync(TripPerson value, string? id)
        {
            value.Validate(nameof(value)).Mandatory().Run().ThrowOnError();

            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Update;
                value.Id = id;
                EntityBase.CleanUp(value, id);
                if (_updateOnPreValidateAsync != null) await _updateOnPreValidateAsync(value, id).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(value.Validate(nameof(value)))
                    .Additional((__mv) => _updateOnValidate?.Invoke(__mv, value, id))
                    .Run().ThrowOnError();

                if (_updateOnBeforeAsync != null) await _updateOnBeforeAsync(value, id).ConfigureAwait(false);
                var __result = await TripPersonDataSvc.UpdateAsync(value).ConfigureAwait(false);
                if (_updateOnAfterAsync != null) await _updateOnAfterAsync(__result, id).ConfigureAwait(false);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Deletes the <see cref="TripPerson"/> object.
        /// </summary>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        public Task DeleteAsync(string? id)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Delete;
                EntityBase.CleanUp(id);
                if (_deleteOnPreValidateAsync != null) await _deleteOnPreValidateAsync(id).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(id.Validate(nameof(id)).Mandatory())
                    .Additional((__mv) => _deleteOnValidate?.Invoke(__mv, id))
                    .Run().ThrowOnError();

                if (_deleteOnBeforeAsync != null) await _deleteOnBeforeAsync(id).ConfigureAwait(false);
                await TripPersonDataSvc.DeleteAsync(id).ConfigureAwait(false);
                if (_deleteOnAfterAsync != null) await _deleteOnAfterAsync(id).ConfigureAwait(false);
            });
        }
    }
}

#nullable restore