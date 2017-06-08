/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace ElmSharp.Accessible
{
    /// <summary>
    /// The delegate to define how to provide informations for <see cref="IAccessibleObject.Name"/> or <see cref="IAccessibleObject.Description"/>.
    /// </summary>
    /// <param name="obj">The sender obj.</param>
    /// <returns>Return information for Name or Description.</returns>
    public delegate string AccessibleInfoProvider (AccessibleObject obj);

    /// <summary>
    /// It's a base abstract class for <see cref="Widget"/>.
    /// It provides available definitions for the screen reader, such as <see cref="IAccessibleObject.Name"/>, <see cref="IAccessibleObject.Description"/>, <see cref="IAccessibleObject.ReadingInfoType"/>, etc.
    /// There's many the relationship between two accessible objects, like <see cref="ChildOf"/>, <see cref="ParentOf"/>, <see cref="FlowsTo"/>, <see cref="FlowsFrom"/>, etc.
    /// </summary>
    public abstract class AccessibleObject : EvasObject, IAccessibleObject
    {

        AccessibleInfoProvider _nameProvider;
        AccessibleInfoProvider _descriptionProvider;

        Interop.Elementary.Elm_Atspi_Reading_Info_Cb _nameProviderInternal;
        Interop.Elementary.Elm_Atspi_Reading_Info_Cb _descriptionProviderInternal;

        /// <summary>
        /// Gets or sets the reading information types of an accessible object.
        /// </summary>
        ReadingInfoType IAccessibleObject.ReadingInfoType
        {
            get
            {
                return (ReadingInfoType)Interop.Elementary.elm_atspi_accessible_reading_info_type_get(Handle);
            }
            set
            {
                Interop.Elementary.elm_atspi_accessible_reading_info_type_set(Handle,
                        (Interop.Elementary.Elm_Accessible_Reading_Info_Type)value);
            }
        }

        /// <summary>
        /// Gets or sets the role of the object in accessibility domain.
        /// </summary>
        AccessRole IAccessibleObject.Role
        {
            get
            {
                return (AccessRole)Interop.Elementary.elm_atspi_accessible_role_get(Handle);
            }
            set
            {
                Interop.Elementary.elm_atspi_accessible_role_set(Handle,
                        (Interop.Elementary.Elm_Atspi_Role)value);
            }
        }

        /// <summary>
        /// Gets or sets highlightable of given widget.
        /// </summary>
        bool IAccessibleObject.CanHighlight
        {
            get
            {
                return Interop.Elementary.elm_atspi_accessible_can_highlight_get(Handle);
            }
            set
            {
                Interop.Elementary.elm_atspi_accessible_can_highlight_set(Handle, value);
            }
        }

        /// <summary>
        /// Gets or sets the translation domain of "name" and "description" properties.
        /// Translation domain should be set if application wants to support i18n for accessibily "name" and "description" properties.
        /// When translation domain is set values of "name" and "description" properties will be translated with dgettext function using current translation domain as "domainname" parameter.
        /// It is application developer responsibility to ensure that translation files are loaded and binded to translation domain when accessibility is enabled.
        /// </summary>
        string IAccessibleObject.TranslationDomain
        {
            get
            {
                return Interop.Elementary.elm_atspi_accessible_translation_domain_get(Handle);
            }
            set
            {
                Interop.Elementary.elm_atspi_accessible_translation_domain_set(Handle, value);
            }
        }

        /// <summary>
        /// Gets or sets an accessible name of the object.
        /// </summary>
        string IAccessibleObject.Name
        {
            get
            {
                return Interop.Elementary.elm_atspi_accessible_name_get(Handle);
            }
            set
            {
                Interop.Elementary.elm_atspi_accessible_name_set(Handle, value);
            }
        }

        /// <summary>
        /// Gets or sets contextual information about object.
        /// </summary>
        string IAccessibleObject.Description
        {
            get
            {
                return Interop.Elementary.elm_atspi_accessible_description_get(Handle);
            }
            set
            {
                Interop.Elementary.elm_atspi_accessible_description_set(Handle, value);
            }
        }

        /// <summary>
        /// Gets or sets the delegate for <see cref="IAccessibleObject.Name"/>.
        /// </summary>
        AccessibleInfoProvider IAccessibleObject.NameProvider
        {
            get
            {
                return _nameProvider;
            }

            set
            {
                if (_nameProviderInternal == null)
                {
                    _nameProviderInternal = (data, obj) => _nameProvider(this);
                }
                if (value == null)
                {
                    _nameProvider = null;
                    Interop.Elementary.elm_atspi_accessible_name_cb_set(Handle, null, IntPtr.Zero);
                }
                else
                {
                    _nameProvider = new AccessibleInfoProvider(value);
                    Interop.Elementary.elm_atspi_accessible_name_cb_set(Handle, _nameProviderInternal, IntPtr.Zero);
                }
            }
        }

        /// <summary>
        /// Gets or sets the delegate for <see cref = "IAccessibleObject.Description" />.
        /// </summary>
        AccessibleInfoProvider IAccessibleObject.DescriptionProvider
        {
            get
            {
                return _descriptionProvider;
            }

            set
            {
                if (_descriptionProviderInternal == null)
                {
                    _descriptionProviderInternal = (data, obj) => _descriptionProvider(this);
                }
                if (value == null)
                {
                    _descriptionProvider = null;
                    Interop.Elementary.elm_atspi_accessible_description_cb_set(Handle, null, IntPtr.Zero);
                }
                else
                {
                    _descriptionProvider = new AccessibleInfoProvider(value);
                    Interop.Elementary.elm_atspi_accessible_description_cb_set(Handle, _descriptionProviderInternal, IntPtr.Zero);
                }
            }
        }

        /// <summary>
        /// Creates and initializes a new instance of the AccessibleObject class with parent EvasObject class parameter.
        /// </summary>
        /// <param name="parent">Parent EvasObject class </param>
        public AccessibleObject(EvasObject parent) : base(parent)
        {
        }

        /// <summary>
        /// Creates and initializes a new instance of the AccessibleObject class.
        /// </summary>
        public AccessibleObject() : base()
        {
        }

        /// <summary>
        /// Defines the relationship between two accessible objects.
        /// Relationships can be queried by Assistive Technology clients to provide customized feedback, improving overall user experience.
        /// AppendRelation API is asymmetric, which means that appending, for example, relation <see cref="FlowsTo"/> from object A to B, do not append relation <see cref="FlowsFrom"/> from object B to object A.
        /// </summary>
        /// <param name="relation">The relationship between source object and target object of a given type.</param>
        void IAccessibleObject.AppendRelation(IAccessibleRelation relation)
        {
            if (relation.Target == null) throw new ArgumentException("Target of Accessibility relation can not be null");
            Interop.Elementary.elm_atspi_accessible_relationship_append(Handle, relation.Type, relation.Target.Handle);
        }

        /// <summary>
        /// Removes the relationship between two accessible objects.
        /// </summary>
        /// <param name="relation">The relationship between source object and target object of a given type.</param>
        void IAccessibleObject.RemoveRelation(IAccessibleRelation relation)
        {
            if (relation.Target == null) throw new ArgumentException("Target of Accessibility relation can not be null");
            Interop.Elementary.elm_atspi_accessible_relationship_remove(Handle, relation.Type, relation.Target.Handle);
        }

        /// <summary>
        /// Highlights accessible widget.
        /// </summary>
        public void Highlight()
        {
            Interop.Elementary.elm_atspi_component_highlight_grab(Handle);
        }

        /// <summary>
        /// Clears highlight of accessible widget.
        /// </summary>
        public void Unhighlight()
        {
            Interop.Elementary.elm_atspi_component_highlight_clear(Handle);
        }
    }
}
