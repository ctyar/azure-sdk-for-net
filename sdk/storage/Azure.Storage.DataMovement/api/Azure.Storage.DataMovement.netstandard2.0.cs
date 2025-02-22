namespace Azure.Storage.DataMovement
{
    public partial class DataTransfer
    {
        internal DataTransfer() { }
        public bool HasCompleted { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.Storage.DataMovement.TransferManager TransferManager { get { throw null; } }
        public Azure.Storage.DataMovement.StorageTransferStatus TransferStatus { get { throw null; } }
        public void EnsureCompleted(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { }
        public virtual System.Threading.Tasks.Task PauseIfRunningAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public System.Threading.Tasks.Task WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DataTransferProperties
    {
        protected internal DataTransferProperties() { }
        public virtual Azure.Storage.DataMovement.TransferCheckpointerOptions Checkpointer { get { throw null; } }
        public virtual string DestinationPath { get { throw null; } }
        public virtual string DestinationTypeId { get { throw null; } }
        public virtual bool IsContainer { get { throw null; } }
        public virtual string SourcePath { get { throw null; } }
        public virtual string SourceTypeId { get { throw null; } }
        public virtual string TransferId { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum ErrorHandlingBehavior
    {
        StopOnAllFailures = 0,
        ContinueOnFailure = 1,
    }
    public partial class LocalDirectoryStorageResourceContainer : Azure.Storage.DataMovement.StorageResourceContainer
    {
        public LocalDirectoryStorageResourceContainer(string path) { }
        protected internal override bool CanProduceUri { get { throw null; } }
        public override string Path { get { throw null; } }
        public override System.Uri Uri { get { throw null; } }
        protected internal override Azure.Storage.DataMovement.StorageResourceSingle GetChildStorageResource(string childPath) { throw null; }
        protected internal override System.Collections.Generic.IAsyncEnumerable<Azure.Storage.DataMovement.StorageResource> GetStorageResourcesAsync([System.Runtime.CompilerServices.EnumeratorCancellationAttribute] System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class LocalFileStorageResource : Azure.Storage.DataMovement.StorageResourceSingle
    {
        public LocalFileStorageResource(string path) { }
        protected internal override bool CanProduceUri { get { throw null; } }
        protected internal override long? Length { get { throw null; } }
        protected internal override long MaxChunkSize { get { throw null; } }
        public override string Path { get { throw null; } }
        protected internal override string ResourceId { get { throw null; } }
        protected internal override Azure.Storage.DataMovement.TransferType TransferType { get { throw null; } }
        public override System.Uri Uri { get { throw null; } }
        protected internal override System.Threading.Tasks.Task CompleteTransferAsync(bool overwrite, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected internal override System.Threading.Tasks.Task CopyBlockFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, Azure.HttpRange range, bool overwrite, long completeLength = (long)0, Azure.Storage.DataMovement.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected internal override System.Threading.Tasks.Task CopyFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, bool overwrite, long completeLength, Azure.Storage.DataMovement.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected internal override System.Threading.Tasks.Task<bool> DeleteIfExistsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected internal override System.Threading.Tasks.Task<Azure.HttpAuthorization> GetCopyAuthorizationHeaderAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected internal override System.Threading.Tasks.Task<Azure.Storage.DataMovement.StorageResourceProperties> GetPropertiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected internal override System.Threading.Tasks.Task<Azure.Storage.DataMovement.ReadStreamStorageResourceResult> ReadStreamAsync(long position = (long)0, long? length = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected internal override System.Threading.Tasks.Task WriteFromStreamAsync(System.IO.Stream stream, long streamLength, bool overwrite, long position = (long)0, long completeLength = (long)0, Azure.Storage.DataMovement.StorageResourceWriteToOffsetOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class LocalStorageResourceProvider
    {
        internal LocalStorageResourceProvider() { }
        public Azure.Storage.DataMovement.StorageResource MakeResource() { throw null; }
    }
    public static partial class LocalStorageResources
    {
        public static bool TryGetResourceProviders(Azure.Storage.DataMovement.DataTransferProperties info, out Azure.Storage.DataMovement.LocalStorageResourceProvider sourceProvider, out Azure.Storage.DataMovement.LocalStorageResourceProvider destinationProvider) { throw null; }
    }
    public partial class ProgressHandlerOptions
    {
        public ProgressHandlerOptions() { }
        public bool TrackBytesTransferred { get { throw null; } set { } }
    }
    public partial class ReadStreamStorageResourceResult
    {
        public ReadStreamStorageResourceResult(System.IO.Stream content) { }
        public ReadStreamStorageResourceResult(System.IO.Stream content, string contentRange, string acceptRanges, byte[] rangeContentHash, Azure.Storage.DataMovement.StorageResourceProperties properties) { }
    }
    public partial class SingleTransferCompletedEventArgs : Azure.Storage.DataMovement.StorageTransferEventArgs
    {
        public SingleTransferCompletedEventArgs(string transferId, Azure.Storage.DataMovement.StorageResourceSingle sourceResource, Azure.Storage.DataMovement.StorageResourceSingle destinationResource, bool isRunningSynchronously, System.Threading.CancellationToken cancellationToken) : base (default(string), default(bool), default(System.Threading.CancellationToken)) { }
        public Azure.Storage.DataMovement.StorageResourceSingle DestinationResource { get { throw null; } }
        public Azure.Storage.DataMovement.StorageResourceSingle SourceResource { get { throw null; } }
    }
    public abstract partial class StorageResource
    {
        protected StorageResource() { }
        protected internal abstract bool CanProduceUri { get; }
        protected internal abstract bool IsContainer { get; }
        public abstract string Path { get; }
        public abstract System.Uri Uri { get; }
    }
    public abstract partial class StorageResourceContainer : Azure.Storage.DataMovement.StorageResource
    {
        protected StorageResourceContainer() { }
        protected internal override bool IsContainer { get { throw null; } }
        protected internal abstract Azure.Storage.DataMovement.StorageResourceSingle GetChildStorageResource(string path);
        protected internal abstract System.Collections.Generic.IAsyncEnumerable<Azure.Storage.DataMovement.StorageResource> GetStorageResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public partial class StorageResourceCopyFromUriOptions
    {
        public StorageResourceCopyFromUriOptions() { }
        public string BlockId { get { throw null; } }
        public Azure.HttpAuthorization SourceAuthentication { get { throw null; } set { } }
    }
    public enum StorageResourceCreateMode
    {
        None = 0,
        Overwrite = 1,
        Fail = 2,
        Skip = 3,
    }
    public partial class StorageResourceProperties
    {
        protected StorageResourceProperties() { }
        public StorageResourceProperties(System.DateTimeOffset lastModified, System.DateTimeOffset createdOn, System.Collections.Generic.IDictionary<string, string> metadata, System.DateTimeOffset copyCompletedOn, string copyStatusDescription, string copyId, string copyProgress, System.Uri copySource, long contentLength, string contentType, Azure.ETag eTag, byte[] contentHash, long blobSequenceNumber, int blobCommittedBlockCount, bool isServerEncrypted, string encryptionKeySha256, string encryptionScope, string versionId, bool isLatestVersion, System.DateTimeOffset expiresOn, System.DateTimeOffset lastAccessed) { }
        public StorageResourceProperties(System.DateTimeOffset lastModified, System.DateTimeOffset createdOn, long contentLength, System.DateTimeOffset lastAccessed) { }
    }
    public abstract partial class StorageResourceSingle : Azure.Storage.DataMovement.StorageResource
    {
        protected StorageResourceSingle() { }
        protected internal override bool IsContainer { get { throw null; } }
        protected internal abstract long? Length { get; }
        protected internal abstract long MaxChunkSize { get; }
        protected internal abstract string ResourceId { get; }
        protected internal abstract Azure.Storage.DataMovement.TransferType TransferType { get; }
        protected internal abstract System.Threading.Tasks.Task CompleteTransferAsync(bool overwrite, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        protected internal abstract System.Threading.Tasks.Task CopyBlockFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, Azure.HttpRange range, bool overwrite, long completeLength = (long)0, Azure.Storage.DataMovement.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        protected internal abstract System.Threading.Tasks.Task CopyFromUriAsync(Azure.Storage.DataMovement.StorageResourceSingle sourceResource, bool overwrite, long completeLength, Azure.Storage.DataMovement.StorageResourceCopyFromUriOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        protected internal abstract System.Threading.Tasks.Task<bool> DeleteIfExistsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        protected internal abstract System.Threading.Tasks.Task<Azure.HttpAuthorization> GetCopyAuthorizationHeaderAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        protected internal abstract System.Threading.Tasks.Task<Azure.Storage.DataMovement.StorageResourceProperties> GetPropertiesAsync(System.Threading.CancellationToken token = default(System.Threading.CancellationToken));
        protected internal abstract System.Threading.Tasks.Task<Azure.Storage.DataMovement.ReadStreamStorageResourceResult> ReadStreamAsync(long position = (long)0, long? length = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        protected internal abstract System.Threading.Tasks.Task WriteFromStreamAsync(System.IO.Stream stream, long streamLength, bool overwrite, long position = (long)0, long completeLength = (long)0, Azure.Storage.DataMovement.StorageResourceWriteToOffsetOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public partial class StorageResourceWriteToOffsetOptions
    {
        public StorageResourceWriteToOffsetOptions() { }
        public string BlockId { get { throw null; } }
    }
    public abstract partial class StorageTransferEventArgs : Azure.SyncAsyncEventArgs
    {
        protected StorageTransferEventArgs(string transferId, bool isRunningSynchronously, System.Threading.CancellationToken cancellationToken) : base (default(bool), default(System.Threading.CancellationToken)) { }
        public string TransferId { get { throw null; } }
    }
    public partial class StorageTransferProgress
    {
        public StorageTransferProgress() { }
        public long? BytesTransferred { get { throw null; } }
        public long CompletedCount { get { throw null; } }
        public long FailedCount { get { throw null; } }
        public long InProgressCount { get { throw null; } }
        public long QueuedCount { get { throw null; } }
        public long SkippedCount { get { throw null; } }
    }
    public enum StorageTransferStatus
    {
        None = 0,
        Queued = 1,
        InProgress = 2,
        Paused = 3,
        Completed = 4,
        CompletedWithSkippedTransfers = 5,
        CompletedWithFailedTransfers = 6,
        PauseInProgress = 7,
        CancellationInProgress = 8,
    }
    public partial class TransferCheckpointerOptions
    {
        public TransferCheckpointerOptions(string localCheckpointerPath) { }
        public string CheckpointerPath { get { throw null; } }
    }
    public partial class TransferFailedEventArgs : Azure.Storage.DataMovement.StorageTransferEventArgs
    {
        public TransferFailedEventArgs(string transferId, Azure.Storage.DataMovement.StorageResourceSingle sourceResource, Azure.Storage.DataMovement.StorageResourceSingle destinationResource, System.Exception exception, bool isRunningSynchronously, System.Threading.CancellationToken cancellationToken) : base (default(string), default(bool), default(System.Threading.CancellationToken)) { }
        public Azure.Storage.DataMovement.StorageResourceSingle DestinationResource { get { throw null; } }
        public System.Exception Exception { get { throw null; } }
        public Azure.Storage.DataMovement.StorageResourceSingle SourceResource { get { throw null; } }
    }
    public partial class TransferManager : System.IAsyncDisposable
    {
        protected TransferManager() { }
        public TransferManager(Azure.Storage.DataMovement.TransferManagerOptions options = null) { }
        public virtual System.Collections.Generic.IAsyncEnumerable<Azure.Storage.DataMovement.DataTransferProperties> GetResumableTransfersAsync() { throw null; }
        public virtual System.Collections.Generic.IAsyncEnumerable<Azure.Storage.DataMovement.DataTransfer> GetTransfersAsync(params Azure.Storage.DataMovement.StorageTransferStatus[] filterByStatus) { throw null; }
        public virtual System.Threading.Tasks.Task PauseTransferIfRunningAsync(string transferId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> ResumeTransferAsync(string transferId, Azure.Storage.DataMovement.StorageResource sourceResource, Azure.Storage.DataMovement.StorageResource destinationResource, Azure.Storage.DataMovement.TransferOptions transferOptions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartTransferAsync(Azure.Storage.DataMovement.StorageResource sourceResource, Azure.Storage.DataMovement.StorageResource destinationResource, Azure.Storage.DataMovement.TransferOptions transferOptions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync() { throw null; }
    }
    public partial class TransferManagerOptions
    {
        public TransferManagerOptions() { }
        public Azure.Storage.DataMovement.TransferCheckpointerOptions CheckpointerOptions { get { throw null; } set { } }
        public Azure.Core.DiagnosticsOptions Diagnostics { get { throw null; } }
        public Azure.Storage.DataMovement.ErrorHandlingBehavior ErrorHandling { get { throw null; } set { } }
        public int? MaximumConcurrency { get { throw null; } set { } }
    }
    public partial class TransferOptions : System.IEquatable<Azure.Storage.DataMovement.TransferOptions>
    {
        public TransferOptions() { }
        public Azure.Storage.DataMovement.StorageResourceCreateMode CreateMode { get { throw null; } set { } }
        public long? InitialTransferSize { get { throw null; } set { } }
        public long? MaximumTransferChunkSize { get { throw null; } set { } }
        public System.IProgress<Azure.Storage.DataMovement.StorageTransferProgress> ProgressHandler { get { throw null; } set { } }
        public Azure.Storage.DataMovement.ProgressHandlerOptions ProgressHandlerOptions { get { throw null; } set { } }
        public event Azure.Core.SyncAsyncEventHandler<Azure.Storage.DataMovement.SingleTransferCompletedEventArgs> SingleTransferCompleted { add { } remove { } }
        public event Azure.Core.SyncAsyncEventHandler<Azure.Storage.DataMovement.TransferFailedEventArgs> TransferFailed { add { } remove { } }
        public event Azure.Core.SyncAsyncEventHandler<Azure.Storage.DataMovement.TransferSkippedEventArgs> TransferSkipped { add { } remove { } }
        public event Azure.Core.SyncAsyncEventHandler<Azure.Storage.DataMovement.TransferStatusEventArgs> TransferStatus { add { } remove { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool Equals(Azure.Storage.DataMovement.TransferOptions obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static bool operator ==(Azure.Storage.DataMovement.TransferOptions left, Azure.Storage.DataMovement.TransferOptions right) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static bool operator !=(Azure.Storage.DataMovement.TransferOptions left, Azure.Storage.DataMovement.TransferOptions right) { throw null; }
    }
    public partial class TransferSkippedEventArgs : Azure.Storage.DataMovement.StorageTransferEventArgs
    {
        public TransferSkippedEventArgs(string transferId, Azure.Storage.DataMovement.StorageResourceSingle sourceResource, Azure.Storage.DataMovement.StorageResourceSingle destinationResource, bool isRunningSynchronously, System.Threading.CancellationToken cancellationToken) : base (default(string), default(bool), default(System.Threading.CancellationToken)) { }
        public Azure.Storage.DataMovement.StorageResourceSingle DestinationResource { get { throw null; } }
        public Azure.Storage.DataMovement.StorageResourceSingle SourceResource { get { throw null; } }
    }
    public partial class TransferStatusEventArgs : Azure.Storage.DataMovement.StorageTransferEventArgs
    {
        public TransferStatusEventArgs(string transferId, Azure.Storage.DataMovement.StorageTransferStatus transferStatus, bool isRunningSynchronously, System.Threading.CancellationToken cancellationToken) : base (default(string), default(bool), default(System.Threading.CancellationToken)) { }
        public Azure.Storage.DataMovement.StorageTransferStatus StorageTransferStatus { get { throw null; } }
    }
    public enum TransferType
    {
        Concurrent = 0,
        Sequential = 1,
    }
}
