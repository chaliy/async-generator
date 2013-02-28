using System;
using System.Threading.Tasks;

namespace AzureExample  {
  static class ServiceBusAsyncExtensions
  {
  
    
    public static Task<Microsoft.ServiceBus.Messaging.MessageSession> AcceptMessageSessionAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.MessageSession>.Factory.FromAsync(@this.BeginAcceptMessageSession, @this.EndAcceptMessageSession
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.MessageSession> AcceptMessageSessionAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.String sessionId
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.MessageSession>.Factory.FromAsync(@this.BeginAcceptMessageSession, @this.EndAcceptMessageSession
              ,sessionId
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.MessageSession> AcceptMessageSessionAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.TimeSpan serverWaitTime
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.MessageSession>.Factory.FromAsync(@this.BeginAcceptMessageSession, @this.EndAcceptMessageSession
              ,serverWaitTime
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.MessageSession> AcceptMessageSessionAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.String sessionId
          ,System.TimeSpan serverWaitTime
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.MessageSession>.Factory.FromAsync(@this.BeginAcceptMessageSession, @this.EndAcceptMessageSession
              ,sessionId
              ,serverWaitTime
            , null);
    }

    
  
    
    public static Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.MessageSession>> GetMessageSessionsAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.MessageSession>>.Factory.FromAsync(@this.BeginGetMessageSessions, @this.EndGetMessageSessions
            , null);
    }

    
  
    
    public static Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.MessageSession>> GetMessageSessionsAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.DateTime lastUpdatedTime
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.MessageSession>>.Factory.FromAsync(@this.BeginGetMessageSessions, @this.EndGetMessageSessions
              ,lastUpdatedTime
            , null);
    }

    
  
    
    public static Task AbandonAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Guid lockToken
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginAbandon, @this.EndAbandon
              ,lockToken
            , null);
    }

    
  
    
    public static Task AbandonAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Guid lockToken
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginAbandon, @this.EndAbandon
              ,lockToken
              ,propertiesToModify
            , null);
    }

    
  
    
    public static Task CompleteAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Guid lockToken
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginComplete, @this.EndComplete
              ,lockToken
            , null);
    }

    
  
    
    public static Task CompleteBatchAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Collections.Generic.IEnumerable<System.Guid> lockTokens
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginCompleteBatch, @this.EndCompleteBatch
              ,lockTokens
            , null);
    }

    
  
    
    public static Task DeferAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Guid lockToken
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDefer, @this.EndDefer
              ,lockToken
            , null);
    }

    
  
    
    public static Task DeferAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Guid lockToken
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDefer, @this.EndDefer
              ,lockToken
              ,propertiesToModify
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Guid lockToken
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
              ,lockToken
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Guid lockToken
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
              ,lockToken
              ,propertiesToModify
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Guid lockToken
          ,System.String deadLetterReason
          ,System.String deadLetterErrorDescription
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
              ,lockToken
              ,deadLetterReason
              ,deadLetterErrorDescription
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.BrokeredMessage> ReceiveAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.BrokeredMessage>.Factory.FromAsync(@this.BeginReceive, @this.EndReceive
            , null);
    }

    
  
    
    public static Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>> ReceiveBatchAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Int32 messageCount
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>>.Factory.FromAsync(@this.BeginReceiveBatch, @this.EndReceiveBatch
              ,messageCount
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.BrokeredMessage> ReceiveAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.TimeSpan serverWaitTime
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.BrokeredMessage>.Factory.FromAsync(@this.BeginReceive, @this.EndReceive
              ,serverWaitTime
            , null);
    }

    
  
    
    public static Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>> ReceiveBatchAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Int32 messageCount
          ,System.TimeSpan serverWaitTime
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>>.Factory.FromAsync(@this.BeginReceiveBatch, @this.EndReceiveBatch
              ,messageCount
              ,serverWaitTime
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.BrokeredMessage> ReceiveAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Int64 sequenceNumber
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.BrokeredMessage>.Factory.FromAsync(@this.BeginReceive, @this.EndReceive
              ,sequenceNumber
            , null);
    }

    
  
    
    public static Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>> ReceiveBatchAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Collections.Generic.IEnumerable<System.Int64> sequenceNumbers
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>>.Factory.FromAsync(@this.BeginReceiveBatch, @this.EndReceiveBatch
              ,sequenceNumbers
            , null);
    }

    
  
    
    public static Task SendAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,Microsoft.ServiceBus.Messaging.BrokeredMessage message
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginSend, @this.EndSend
              ,message
            , null);
    }

    
  
    
    public static Task SendBatchAsync(this Microsoft.ServiceBus.Messaging.QueueClient @this
          ,System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage> messages
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginSendBatch, @this.EndSendBatch
              ,messages
            , null);
    }

    
  
    
    public static Task AbandonAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Guid lockToken
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginAbandon, @this.EndAbandon
              ,lockToken
            , null);
    }

    
  
    
    public static Task AbandonAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Guid lockToken
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginAbandon, @this.EndAbandon
              ,lockToken
              ,propertiesToModify
            , null);
    }

    
  
    
    public static Task CompleteAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Guid lockToken
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginComplete, @this.EndComplete
              ,lockToken
            , null);
    }

    
  
    
    public static Task CompleteBatchAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Collections.Generic.IEnumerable<System.Guid> lockTokens
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginCompleteBatch, @this.EndCompleteBatch
              ,lockTokens
            , null);
    }

    
  
    
    public static Task DeferAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Guid lockToken
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDefer, @this.EndDefer
              ,lockToken
            , null);
    }

    
  
    
    public static Task DeferAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Guid lockToken
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDefer, @this.EndDefer
              ,lockToken
              ,propertiesToModify
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.BrokeredMessage> ReceiveAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.BrokeredMessage>.Factory.FromAsync(@this.BeginReceive, @this.EndReceive
            , null);
    }

    
  
    
    public static Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>> ReceiveBatchAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Int32 messageCount
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>>.Factory.FromAsync(@this.BeginReceiveBatch, @this.EndReceiveBatch
              ,messageCount
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.BrokeredMessage> ReceiveAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.TimeSpan serverWaitTime
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.BrokeredMessage>.Factory.FromAsync(@this.BeginReceive, @this.EndReceive
              ,serverWaitTime
            , null);
    }

    
  
    
    public static Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>> ReceiveBatchAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Int32 messageCount
          ,System.TimeSpan serverWaitTime
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>>.Factory.FromAsync(@this.BeginReceiveBatch, @this.EndReceiveBatch
              ,messageCount
              ,serverWaitTime
            , null);
    }

    
  
    
    public static Task<Microsoft.ServiceBus.Messaging.BrokeredMessage> ReceiveAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Int64 sequenceNumber
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<Microsoft.ServiceBus.Messaging.BrokeredMessage>.Factory.FromAsync(@this.BeginReceive, @this.EndReceive
              ,sequenceNumber
            , null);
    }

    
  
    
    public static Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>> ReceiveBatchAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Collections.Generic.IEnumerable<System.Int64> sequenceNumbers
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task<System.Collections.Generic.IEnumerable<Microsoft.ServiceBus.Messaging.BrokeredMessage>>.Factory.FromAsync(@this.BeginReceiveBatch, @this.EndReceiveBatch
              ,sequenceNumbers
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Guid lockToken
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
              ,lockToken
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Guid lockToken
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
              ,lockToken
              ,propertiesToModify
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.MessageReceiver @this
          ,System.Guid lockToken
          ,System.String deadLetterReason
          ,System.String deadLetterErrorDescription
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
              ,lockToken
              ,deadLetterReason
              ,deadLetterErrorDescription
            , null);
    }

    
  
    
    public static Task AbandonAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginAbandon, @this.EndAbandon
            , null);
    }

    
  
    
    public static Task AbandonAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginAbandon, @this.EndAbandon
              ,propertiesToModify
            , null);
    }

    
  
    
    public static Task RenewLockAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginRenewLock, @this.EndRenewLock
            , null);
    }

    
  
    
    public static Task CompleteAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginComplete, @this.EndComplete
            , null);
    }

    
  
    
    public static Task DeferAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDefer, @this.EndDefer
            , null);
    }

    
  
    
    public static Task DeferAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDefer, @this.EndDefer
              ,propertiesToModify
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
          ,System.String deadLetterReason
          ,System.String deadLetterErrorDescription
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
              ,deadLetterReason
              ,deadLetterErrorDescription
            , null);
    }

    
  
    
    public static Task DeadLetterAsync(this Microsoft.ServiceBus.Messaging.BrokeredMessage @this
          ,System.Collections.Generic.IDictionary<System.String,System.Object> propertiesToModify
        )
    {
      if (@this == null) throw new ArgumentNullException("this");
      return Task.Factory.FromAsync(@this.BeginDeadLetter, @this.EndDeadLetter
              ,propertiesToModify
            , null);
    }

    
    }
}

