﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using SkiaSharp;

namespace Modern.Forms
{
    public class ListViewItemCollection : Collection<ListViewItem>
    {
        private readonly ListView owner;

        internal ListViewItemCollection (ListView owner)
        {
            this.owner = owner;
        }

        public ListViewItem Add (string text)
        {
            var item = new ListViewItem {
                Text = text
            };

            Add (item);

            return item;
        }

        public ListViewItem Add (string text, SKBitmap image)
        {
            var item = new ListViewItem {
                Text = text,
                Image = image
            };

            Add (item);

            return item;
        }

        protected override void InsertItem (int index, ListViewItem item)
        {
            base.InsertItem (index, item);

            item.Parent = owner;
            owner.Invalidate ();
        }

        protected override void RemoveItem (int index)
        {
            var item = this[index];

            base.RemoveItem (index);

            item.Parent = null;
            owner.Invalidate ();
        }

        protected override void SetItem (int index, ListViewItem item)
        {
            var old_item = this.ElementAtOrDefault (index);

            if (old_item != null)
                old_item.Parent = null;

            base.SetItem (index, item);

            item.Parent = owner;
            owner.Invalidate ();
        }
    }
}
