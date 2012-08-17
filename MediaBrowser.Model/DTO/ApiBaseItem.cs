﻿using System;
using System.Collections.Generic;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Users;

namespace MediaBrowser.Model.DTO
{
    /// <summary>
    /// This is a concrete class that the UI can use to deserialize
    /// It is flat in the sense that it will be used regardless of the type of BaseItem involved
    /// </summary>
    public class ApiBaseItem : BaseItem
    {
        // Series properties
        public string Status { get; set; }
        public IEnumerable<DayOfWeek> AirDays { get; set; }
        public string AirTime { get; set; }
    }

    /// <summary>
    /// This is the full return object when requesting an Item
    /// </summary>
    public class BaseItemContainer<TItemType>
        where TItemType : BaseItem
    {
        public TItemType Item { get; set; }

        public UserItemData UserItemData { get; set; }

        public IEnumerable<BaseItemContainer<TItemType>> Children { get; set; }

        public bool IsFolder { get; set; }

        public Guid? ParentId { get; set; }

        public string Type { get; set; }

        public bool IsType(Type type)
        {
            return IsType(type.Name);
        }

        public bool IsType(string type)
        {
            return Type.Equals(type, StringComparison.OrdinalIgnoreCase);
        }

        public IEnumerable<BaseItemPerson> People { get; set; }
        public IEnumerable<BaseItemStudio> Studios { get; set; }

        /// <summary>
        /// If the item does not have a logo, this will hold the Id of the Parent that has one.
        /// </summary>
        public Guid? ParentLogoItemId { get; set; }

        public Guid? ParentBackdropItemId { get; set; }

        public int? ParentBackdropCount { get; set; }
    }

    /// <summary>
    /// This is strictly for convenience so the UI's don't have to use the verbose generic syntax of BaseItemWrapper<ApiBaseItem>
    /// </summary>
    public class ApiBaseItemContainer : BaseItemContainer<ApiBaseItem>
    {
    }
}
