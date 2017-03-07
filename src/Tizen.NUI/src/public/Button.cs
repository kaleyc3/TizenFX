// Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
// PROPRIETARY/CONFIDENTIAL 
// This software is the confidential and proprietary
// information of SAMSUNG ELECTRONICS ("Confidential Information"). You shall
// not disclose such Confidential Information and shall use it only in
// accordance with the terms of the license agreement you entered into with
// SAMSUNG ELECTRONICS. SAMSUNG make no representations or warranties about the
// suitability of the software, either express or implied, including but not
// limited to the implied warranties of merchantability, fitness for a
// particular purpose, or non-infringement. SAMSUNG shall not be liable for any
// damages suffered by licensee as a result of using, modifying or distributing
// this software or its derivatives.

// Copyright (c) 2017 Samsung Electronics Co., Ltd.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
// Some have been manually changed

namespace Tizen.NUI
{

    using System;
    using System.Runtime.InteropServices;


    public class Button : View
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal Button(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Button_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Button obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~Button()
        {
            DisposeQueue.Instance.Add(this);
        }

        public override void Dispose()
        {
            if (!Stage.IsInstalled())
            {
                DisposeQueue.Instance.Add(this);
                return;
            }

            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_Button(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }


        private EventHandlerWithReturnType<object, EventArgs, bool> _clickedEventHandler;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool ClickedCallbackType(global::System.IntPtr data);
        private ClickedCallbackType _clickedCallback;

        public event EventHandlerWithReturnType<object, EventArgs, bool> Clicked
        {
            add
            {
                if (_clickedEventHandler == null)
                {
                    _clickedCallback = OnClicked;
                    ClickedSignal().Connect(_clickedCallback);
                }

                _clickedEventHandler += value;
            }

            remove
            {
                _clickedEventHandler -= value;

                if (_clickedEventHandler == null && _clickedCallback != null)
                {
                    ClickedSignal().Disconnect(_clickedCallback);
                }
            }
        }


        private bool OnClicked(IntPtr data)
        {
            if (_clickedEventHandler != null)
            {
                return _clickedEventHandler(this, null);
            }
            return false;
        }



        private EventHandlerWithReturnType<object, EventArgs, bool> _pressedEventHandler;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool PressedCallbackType(global::System.IntPtr data);
        private PressedCallbackType _pressedCallback;

        public event EventHandlerWithReturnType<object, EventArgs, bool> Pressed
        {
            add
            {
                if (_pressedEventHandler == null)
                {
                    _pressedCallback = OnPressed;
                    PressedSignal().Connect(_pressedCallback);
                }

                _pressedEventHandler += value;
            }

            remove
            {
                _pressedEventHandler -= value;

                if (_pressedEventHandler == null && _pressedCallback != null)
                {
                    this.PressedSignal().Disconnect(_pressedCallback);
                }
            }
        }

        private bool OnPressed(IntPtr data)
        {
            if (_pressedEventHandler != null)
            {
                return _pressedEventHandler(this, null);
            }
            return false;
        }



        private EventHandlerWithReturnType<object, EventArgs, bool> _releasedEventHandler;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool ReleasedCallbackType(global::System.IntPtr data);
        private ReleasedCallbackType _releasedCallback;

        public event EventHandlerWithReturnType<object, EventArgs, bool> Released
        {
            add
            {
                if (_releasedEventHandler == null)
                {
                    _releasedCallback = OnReleased;
                    ReleasedSignal().Connect(_releasedCallback);
                }
                _releasedEventHandler += value;
            }

            remove
            {
                _releasedEventHandler -= value;

                if (_releasedEventHandler == null && _releasedCallback != null)
                {
                    ReleasedSignal().Disconnect(_releasedCallback);
                }

            }
        }

        private bool OnReleased(IntPtr data)
        {
            if (_releasedEventHandler != null)
            {
                return _releasedEventHandler(this, null);
            }
            return false;
        }


        private EventHandlerWithReturnType<object, EventArgs, bool> _stateChangedEventHandler;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool StateChangedCallback(global::System.IntPtr data);
        private StateChangedCallback _stateChangedCallback;

        public event EventHandlerWithReturnType<object, EventArgs, bool> StateChanged
        {
            add
            {
                if (_stateChangedEventHandler == null)
                {
                    _stateChangedCallback = OnStateChanged;
                    StateChangedSignal().Connect(_stateChangedCallback);
                }

                _stateChangedEventHandler += value;
            }

            remove
            {
                _stateChangedEventHandler -= value;

                if (_stateChangedEventHandler == null && _stateChangedCallback != null)
                {
                    StateChangedSignal().Disconnect(_stateChangedCallback);
                }
            }
        }

        private bool OnStateChanged(IntPtr data)
        {
            if (_stateChangedEventHandler != null)
            {
                return _stateChangedEventHandler(this, null);
            }
            return false;
        }



        public static Button GetButtonFromPtr(global::System.IntPtr cPtr)
        {
            Button ret = new Button(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public Tizen.NUI.PropertyMap UnselectedVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.UNSELECTED_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.UNSELECTED_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Tizen.NUI.PropertyMap SelectedVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.SELECTED_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Tizen.NUI.PropertyMap DisabledSelectedVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_SELECTED_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_SELECTED_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Tizen.NUI.PropertyMap DisabledUnselectedVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_UNSELECTED_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_UNSELECTED_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Tizen.NUI.PropertyMap UnselectedBackgroundVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.UNSELECTED_BACKGROUND_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.UNSELECTED_BACKGROUND_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Tizen.NUI.PropertyMap SelectedBackgroundVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.SELECTED_BACKGROUND_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED_BACKGROUND_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Tizen.NUI.PropertyMap DisabledUnselectedBackgroundVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_UNSELECTED_BACKGROUND_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_UNSELECTED_BACKGROUND_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Tizen.NUI.PropertyMap DisabledSelectedBackgroundVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_SELECTED_BACKGROUND_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_SELECTED_BACKGROUND_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        public string LabelRelativeAlignment
        {
            get
            {
                string temp;
                GetProperty(Button.Property.LABEL_RELATIVE_ALIGNMENT).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.LABEL_RELATIVE_ALIGNMENT, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Vector4 LabelPadding
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(Button.Property.LABEL_PADDING).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.LABEL_PADDING, new Tizen.NUI.PropertyValue(value));
            }
        }

        public Vector4 VisualPadding
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(Button.Property.VISUAL_PADDING).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.VISUAL_PADDING, new Tizen.NUI.PropertyValue(value));
            }
        }

        internal class Property : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal Property(global::System.IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
            }

            ~Property()
            {
                Dispose();
            }

            public virtual void Dispose()
            {
                lock (this)
                {
                    if (swigCPtr.Handle != global::System.IntPtr.Zero)
                    {
                        if (swigCMemOwn)
                        {
                            swigCMemOwn = false;
                            NDalicPINVOKE.delete_Button_Property(swigCPtr);
                        }
                        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                    }
                    global::System.GC.SuppressFinalize(this);
                }
            }

            internal static readonly int UNSELECTED_VISUAL = NDalicManualPINVOKE.Button_Property_UNSELECTED_VISUAL_get();
            internal static readonly int SELECTED_VISUAL = NDalicManualPINVOKE.Button_Property_SELECTED_VISUAL_get();
            internal static readonly int DISABLED_SELECTED_VISUAL = NDalicManualPINVOKE.Button_Property_DISABLED_SELECTED_VISUAL_get();
            internal static readonly int DISABLED_UNSELECTED_VISUAL = NDalicManualPINVOKE.Button_Property_DISABLED_UNSELECTED_VISUAL_get();
            internal static readonly int UNSELECTED_BACKGROUND_VISUAL = NDalicManualPINVOKE.Button_Property_UNSELECTED_BACKGROUND_VISUAL_get();
            internal static readonly int SELECTED_BACKGROUND_VISUAL = NDalicManualPINVOKE.Button_Property_SELECTED_BACKGROUND_VISUAL_get();
            internal static readonly int DISABLED_UNSELECTED_BACKGROUND_VISUAL = NDalicManualPINVOKE.Button_Property_DISABLED_UNSELECTED_BACKGROUND_VISUAL_get();
            internal static readonly int DISABLED_SELECTED_BACKGROUND_VISUAL = NDalicManualPINVOKE.Button_Property_DISABLED_SELECTED_BACKGROUND_VISUAL_get();
            internal static readonly int LABEL_RELATIVE_ALIGNMENT = NDalicManualPINVOKE.Button_Property_LABEL_RELATIVE_ALIGNMENT_get();
            internal static readonly int LABEL_PADDING = NDalicManualPINVOKE.Button_Property_LABEL_PADDING_get();
            internal static readonly int VISUAL_PADDING = NDalicManualPINVOKE.Button_Property_VISUAL_PADDING_get();
            //changed
            internal Property() : this(NDalicPINVOKE.new_Button_Property(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            internal static readonly int DISABLED = NDalicPINVOKE.Button_Property_DISABLED_get();
            internal static readonly int AUTO_REPEATING = NDalicPINVOKE.Button_Property_AUTO_REPEATING_get();
            internal static readonly int INITIAL_AUTO_REPEATING_DELAY = NDalicPINVOKE.Button_Property_INITIAL_AUTO_REPEATING_DELAY_get();
            internal static readonly int NEXT_AUTO_REPEATING_DELAY = NDalicPINVOKE.Button_Property_NEXT_AUTO_REPEATING_DELAY_get();
            internal static readonly int TOGGLABLE = NDalicPINVOKE.Button_Property_TOGGLABLE_get();
            internal static readonly int SELECTED = NDalicPINVOKE.Button_Property_SELECTED_get();
            internal static readonly int UNSELECTED_STATE_IMAGE = NDalicPINVOKE.Button_Property_UNSELECTED_STATE_IMAGE_get();
            internal static readonly int SELECTED_STATE_IMAGE = NDalicPINVOKE.Button_Property_SELECTED_STATE_IMAGE_get();
            internal static readonly int DISABLED_STATE_IMAGE = NDalicPINVOKE.Button_Property_DISABLED_STATE_IMAGE_get();
            internal static readonly int UNSELECTED_COLOR = NDalicPINVOKE.Button_Property_UNSELECTED_COLOR_get();
            internal static readonly int SELECTED_COLOR = NDalicPINVOKE.Button_Property_SELECTED_COLOR_get();
            internal static readonly int LABEL = NDalicPINVOKE.Button_Property_LABEL_get();
            internal static readonly int LABEL_TEXT = NDalicPINVOKE.Button_Property_LABEL_TEXT_get();

        }

        public Button() : this(NDalicPINVOKE.new_Button__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal Button(Button button) : this(NDalicPINVOKE.new_Button__SWIG_1(Button.getCPtr(button)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal Button Assign(Button button)
        {
            Button ret = new Button(NDalicPINVOKE.Button_Assign(swigCPtr, Button.getCPtr(button)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public new static Button DownCast(BaseHandle handle)
        {
            Button ret = new Button(NDalicPINVOKE.Button_DownCast(BaseHandle.getCPtr(handle)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal bool IsDisabled()
        {
            bool ret = NDalicPINVOKE.Button_IsDisabled(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal bool IsAutoRepeating()
        {
            bool ret = NDalicPINVOKE.Button_IsAutoRepeating(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float GetInitialAutoRepeatingDelay()
        {
            float ret = NDalicPINVOKE.Button_GetInitialAutoRepeatingDelay(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float GetNextAutoRepeatingDelay()
        {
            float ret = NDalicPINVOKE.Button_GetNextAutoRepeatingDelay(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal bool IsTogglableButton()
        {
            bool ret = NDalicPINVOKE.Button_IsTogglableButton(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal bool IsSelected()
        {
            bool ret = NDalicPINVOKE.Button_IsSelected(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public float GetAnimationTime()
        {
            float ret = NDalicPINVOKE.Button_GetAnimationTime(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal string GetLabelText()
        {
            string ret = NDalicPINVOKE.Button_GetLabelText(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetLabel(Actor label)
        {
            NDalicPINVOKE.Button_SetLabel(swigCPtr, Actor.getCPtr(label));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void SetButtonImage(Image image)
        {
            NDalicPINVOKE.Button_SetButtonImage(swigCPtr, Image.getCPtr(image));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void SetSelectedImage(Image image)
        {
            NDalicPINVOKE.Button_SetSelectedImage(swigCPtr, Image.getCPtr(image));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal Actor GetButtonImage()
        {
            Actor ret = new Actor(NDalicPINVOKE.Button_GetButtonImage(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal Actor GetSelectedImage()
        {
            Actor ret = new Actor(NDalicPINVOKE.Button_GetSelectedImage(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ButtonSignal PressedSignal()
        {
            ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_PressedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ButtonSignal ReleasedSignal()
        {
            ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_ReleasedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ButtonSignal ClickedSignal()
        {
            ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_ClickedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ButtonSignal StateChangedSignal()
        {
            ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_StateChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal enum PropertyRange
        {
            PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
            PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX + 1000
        }

        public bool Disabled
        {
            get
            {
                bool temp = false;
                GetProperty(Button.Property.DISABLED).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED, new Tizen.NUI.PropertyValue(value));
            }
        }
        public bool AutoRepeating
        {
            get
            {
                bool temp = false;
                GetProperty(Button.Property.AUTO_REPEATING).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.AUTO_REPEATING, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float InitialAutoRepeatingDelay
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Button.Property.INITIAL_AUTO_REPEATING_DELAY).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.INITIAL_AUTO_REPEATING_DELAY, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float NextAutoRepeatingDelay
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Button.Property.NEXT_AUTO_REPEATING_DELAY).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.NEXT_AUTO_REPEATING_DELAY, new Tizen.NUI.PropertyValue(value));
            }
        }
        public bool Togglable
        {
            get
            {
                bool temp = false;
                GetProperty(Button.Property.TOGGLABLE).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.TOGGLABLE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public bool Selected
        {
            get
            {
                bool temp = false;
                GetProperty(Button.Property.SELECTED).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Tizen.NUI.PropertyMap UnselectedStateImage
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.UNSELECTED_STATE_IMAGE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.UNSELECTED_STATE_IMAGE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Tizen.NUI.PropertyMap SelectedStateImage
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.SELECTED_STATE_IMAGE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED_STATE_IMAGE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Tizen.NUI.PropertyMap DisabledStateImage
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_STATE_IMAGE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_STATE_IMAGE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Color UnselectedColor
        {
            get
            {
                Color temp = new Color(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(Button.Property.UNSELECTED_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.UNSELECTED_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Color SelectedColor
        {
            get
            {
                Color temp = new Color(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(Button.Property.SELECTED_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Tizen.NUI.PropertyMap Label
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.LABEL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.LABEL, new Tizen.NUI.PropertyValue(value));
            }
        }
        public string LabelText
        {
            get
            {
                string temp;
                GetProperty(Button.Property.LABEL_TEXT).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.LABEL_TEXT, new Tizen.NUI.PropertyValue(value));
            }
        }

    }

}