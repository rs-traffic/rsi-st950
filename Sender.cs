﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RSIST950
{
    public class Sender
    {
        //public static readonly TimeSpan MaxWait = TimeSpan.FromMilliseconds(5000);

        ////private IChannel _c;
        //private AutoResetEvent _messageReceived;

        //public Sender()
        //{
        //    // initialize _c
        //    this._messageReceived = new AutoResetEvent(false);
        //    this._c.MessageReceived += this.MessageReceived;
        //}

        //public Message Send(Message m)
        //{
        //   // this._c.Send(m);
        //    // wait for MaxWaitInMs to get an event from _c.MessageReceived
        //    // return the message or null if no message was received in response


        //    // This will wait for up to 5000 ms, then throw an exception.
        //    this._messageReceived.WaitOne(MaxWait);

        //    return null;
        //}

        //public void MessageReceived(object sender, EventArgs e)
        //{
        //    //Do whatever you need to do with the message

        //    this._messageReceived.Set();
        //}
    }
}
