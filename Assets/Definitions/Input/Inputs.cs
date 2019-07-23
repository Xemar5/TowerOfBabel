// GENERATED AUTOMATICALLY FROM 'Assets/Definitions/Input/Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Inputs : IInputActionCollection
{
    private InputActionAsset asset;
    public Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""XBoxOne"",
            ""id"": ""07bb012e-75dd-4659-94a0-7ad4df399d39"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""e7a01c84-8415-4914-9492-b3018f2415e0"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""b126a86a-bb53-4176-9f14-c6aa330f500e"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""9878cbf9-24fd-4175-a2e3-c37d6a6248e3"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""d0528fd7-978f-428a-b378-e75b0ec7b44e"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""7caf686b-b2b6-4498-b390-0b3b6a7b83b3"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""282d6ba5-0b47-4fb5-90d0-a5136f74faf0"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""5690fa45-483e-4fb6-ae91-1a55a905b9d5"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""4f0a6f40-8104-43fd-a51f-324baea02502"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""a7d1e763-bccc-4047-8e88-155adc496080"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8eb03b1a-3db6-44a0-9d48-c01c0806e299"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""7f6012f0-c97e-4e76-b8ab-93b370990df7"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""LRed"",
            ""id"": ""619bef91-fc6b-483b-b203-839eda267182"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""75b84cd5-40bc-4092-848b-02d39a53a241"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""3147d605-e5da-41a2-9978-83afcf929baf"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""ec957dfd-9e22-48a5-a9ec-fc222a4f98f9"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""9c236c46-4129-46ba-b630-0b9aa587d6cf"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""698b1e63-ac19-4cef-b05e-c380297925f9"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""58e40c70-8f39-4c19-991e-7d8111745112"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""ff944a9a-8a6f-4a65-b97e-38219746efd6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""f54fec8a-9a0f-40d1-ab3c-dffcba1c6879"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""54d180dd-7287-4ae8-acb3-619dbff98e90"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""87de70d5-af90-437b-a382-8a8c5d6fcb3d"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""RBrown"",
            ""id"": ""2add42a7-c24d-409b-8ca6-26466a2012f9"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""881b040b-e777-4b3d-9448-752cd89ee616"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""14106b46-6b28-434d-995b-5dd5ba2acbd7"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""9e9410c8-d735-4542-b516-24bd7cdff484"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""6131d878-5edd-4e5a-a0e5-b120e64c2d06"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""0e4ca551-e45b-4a6c-9475-6de65056fae3"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""89bb055f-274d-48f7-bb03-0b7b6649ff9a"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button18"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Brown"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d2a945f0-e6f2-4563-baa3-d84b19d8f503"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button17"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""a1704ca7-77ba-40fe-bded-362de1508bd0"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button16"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""4640e0ba-b08f-4040-8706-02d47717c31d"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button20"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8e031e8d-e2e0-4e6b-bd50-76a7e351b28f"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button19"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Temp Keyboard;Red"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""LGreen"",
            ""id"": ""3f09b0f3-3ef1-4359-ab7c-7f16a83c0a8a"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""e96d53ad-175b-4435-8ee7-99dd603899e9"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""e8a54705-8211-43bd-bb09-d128e3a8aa7f"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""651b0265-8e62-4f98-bac1-8923059f5f23"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""d462bb53-930f-4bb8-b96c-85f5c811f484"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""facb0670-6485-467b-9a30-cfd8f3820af4"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6a44728-6bef-448b-8f67-b17c4ae04df3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""b2398115-afa9-4e9d-80f9-1dbf0ab52341"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8ac7e168-f491-4933-abf3-475a4c50169d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""028b45d9-cac9-411c-85cd-35e3bccef72e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""abc150b8-4588-4933-9569-1fa1c8161f98"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""ROrange"",
            ""id"": ""9da9b91c-feec-4886-bc05-3a57be8cecb0"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""00051745-5d42-4c2d-8371-c0a9ee026297"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""02805fdf-5701-404b-ae51-9993fc0264a6"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""329dd709-e74f-4658-9ae7-9cb7e42d585e"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""ff015c22-3ffd-45bd-88b3-2b64987cb2c0"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""2ed8d3ce-9688-42ac-9bd6-c55f3f61a3f6"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5ed38507-d0b6-4008-8ea9-15484d434b19"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button13"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d2513a1a-39fd-4521-9e60-073d24e93785"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""9427ab77-6827-42ad-a5d0-eafca15b3a75"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""3e6e31d2-c555-4c7e-bc67-bb6296f32d32"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button15"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""08dc0426-37eb-4318-9e2b-3ae7dfa8aae9"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button14"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""LBlue"",
            ""id"": ""79b62b58-5aa8-4723-b661-d47b101b2ead"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""e6447396-3661-4652-8131-183b806d9c34"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""f7598052-4e46-42e7-86e8-032a5598b9db"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""97674e8a-6c01-4998-832f-32c49b592be2"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""2f6137a9-0d47-4365-9bd0-5afaa68f5168"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""6bb1e271-65cf-4e59-8a46-09bec4f63f6c"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""424e0265-714e-41ce-8d03-3a603fddce03"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""a170e00a-14e3-4893-963b-15d16c735a6e"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""2440bf51-5789-47ca-8f13-52a868a71b2c"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d36187e2-776f-40bd-8e50-c9cea70e1ec4"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d780bf30-693b-441d-b5d6-c6840bfa26aa"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""RTeal"",
            ""id"": ""f8a0271b-90fc-4677-96ed-7c94e01b6594"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""b35e87ad-6b2b-4f8c-b247-f67428df4e2d"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""af9d59eb-1562-4c84-85a6-6f21c76905cd"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""84011a58-4f59-4ead-8bcd-f690b752ca08"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""74da0d33-db7e-484c-ab20-0f9a23f05826"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""576bc4ad-9ef3-4ae6-a7d6-d88f9880e10a"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6c73d64e-2168-48f5-b352-f14aa9d83086"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""b9d1dcdf-c07a-42ed-bd84-7699d07ac4cb"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""6e2c8275-d5c2-40a9-8b82-19d232ce8787"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""0655a839-b794-4141-a4c1-bbf511fd23c7"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""b2cd3106-be4a-4fc4-be0f-c119013de9ff"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""LYellow"",
            ""id"": ""e8afa133-c595-4e10-8d34-78a2dd43f1a6"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""375cfc26-2e01-4959-b60e-b82315d44d0a"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""1931d6e4-680a-4cca-85d8-014a15f5e12f"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""6354fc29-d2a0-4a32-b1bd-5de7c950960e"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""09143341-17d7-4338-a7d4-3e9b519511e8"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""39c3a9f5-2ff0-4614-a4b6-b538739bb6a0"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f7355ccd-8448-4108-ba61-efedd9d2e3ae"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""3093c38a-efec-42b3-b007-63c19af3d5ce"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""037c25f3-eee2-44d1-b13d-955a23a0ea82"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""00240807-6e13-4300-954a-e2909878738a"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""9a072c7a-69ad-4ed3-b62e-e565b33ae175"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""RPurple"",
            ""id"": ""dc99d37b-9ec4-4237-b120-23b4bb821241"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""id"": ""42614c4b-6bb9-4764-a4e4-c5be08150082"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""3db419e3-db42-46d5-b780-c03dbadcf770"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""79c0fe9c-6b26-45b5-977f-44b524e3fb73"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""id"": ""45461b5f-ac1c-4c7b-b3f1-ec19cdf238e0"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""id"": ""64c9e8a2-f99d-4618-9788-0537d5f39e13"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""216d1af5-dfe3-4c64-b813-ca35a5450dff"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d023dfb7-7d7c-4727-a9fc-6f28f56b84cb"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""69b4f18b-feb3-4950-97e4-abc2adf4787e"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""2944cec1-b4e1-4382-acf3-7556a55184d5"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""3ed74585-eda6-4222-ad3b-f8f8112a8be3"",
                    ""path"": ""<HID::Namtai Buzz Joystick>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Green"",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""Gameplay"",
            ""id"": ""ced8176f-f3eb-41cc-bc28-3f66f2b815d2"",
            ""actions"": [
                {
                    ""name"": ""Restart"",
                    ""id"": ""2c8240af-53c6-4923-8ceb-26ec04403861"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5aae0db4-0ae2-460d-863b-0bbcc050dc5b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // XBoxOne
        m_XBoxOne = asset.GetActionMap("XBoxOne");
        m_XBoxOne_Left = m_XBoxOne.GetAction("Left");
        m_XBoxOne_Right = m_XBoxOne.GetAction("Right");
        m_XBoxOne_Down = m_XBoxOne.GetAction("Down");
        m_XBoxOne_RotateCounterClockwise = m_XBoxOne.GetAction("RotateCounterClockwise");
        m_XBoxOne_RotateClockwise = m_XBoxOne.GetAction("RotateClockwise");
        // LRed
        m_LRed = asset.GetActionMap("LRed");
        m_LRed_Left = m_LRed.GetAction("Left");
        m_LRed_Right = m_LRed.GetAction("Right");
        m_LRed_Down = m_LRed.GetAction("Down");
        m_LRed_RotateCounterClockwise = m_LRed.GetAction("RotateCounterClockwise");
        m_LRed_RotateClockwise = m_LRed.GetAction("RotateClockwise");
        // RBrown
        m_RBrown = asset.GetActionMap("RBrown");
        m_RBrown_Left = m_RBrown.GetAction("Left");
        m_RBrown_Right = m_RBrown.GetAction("Right");
        m_RBrown_Down = m_RBrown.GetAction("Down");
        m_RBrown_RotateCounterClockwise = m_RBrown.GetAction("RotateCounterClockwise");
        m_RBrown_RotateClockwise = m_RBrown.GetAction("RotateClockwise");
        // LGreen
        m_LGreen = asset.GetActionMap("LGreen");
        m_LGreen_Left = m_LGreen.GetAction("Left");
        m_LGreen_Right = m_LGreen.GetAction("Right");
        m_LGreen_Down = m_LGreen.GetAction("Down");
        m_LGreen_RotateCounterClockwise = m_LGreen.GetAction("RotateCounterClockwise");
        m_LGreen_RotateClockwise = m_LGreen.GetAction("RotateClockwise");
        // ROrange
        m_ROrange = asset.GetActionMap("ROrange");
        m_ROrange_Left = m_ROrange.GetAction("Left");
        m_ROrange_Right = m_ROrange.GetAction("Right");
        m_ROrange_Down = m_ROrange.GetAction("Down");
        m_ROrange_RotateCounterClockwise = m_ROrange.GetAction("RotateCounterClockwise");
        m_ROrange_RotateClockwise = m_ROrange.GetAction("RotateClockwise");
        // LBlue
        m_LBlue = asset.GetActionMap("LBlue");
        m_LBlue_Left = m_LBlue.GetAction("Left");
        m_LBlue_Right = m_LBlue.GetAction("Right");
        m_LBlue_Down = m_LBlue.GetAction("Down");
        m_LBlue_RotateCounterClockwise = m_LBlue.GetAction("RotateCounterClockwise");
        m_LBlue_RotateClockwise = m_LBlue.GetAction("RotateClockwise");
        // RTeal
        m_RTeal = asset.GetActionMap("RTeal");
        m_RTeal_Left = m_RTeal.GetAction("Left");
        m_RTeal_Right = m_RTeal.GetAction("Right");
        m_RTeal_Down = m_RTeal.GetAction("Down");
        m_RTeal_RotateCounterClockwise = m_RTeal.GetAction("RotateCounterClockwise");
        m_RTeal_RotateClockwise = m_RTeal.GetAction("RotateClockwise");
        // LYellow
        m_LYellow = asset.GetActionMap("LYellow");
        m_LYellow_Left = m_LYellow.GetAction("Left");
        m_LYellow_Right = m_LYellow.GetAction("Right");
        m_LYellow_Down = m_LYellow.GetAction("Down");
        m_LYellow_RotateCounterClockwise = m_LYellow.GetAction("RotateCounterClockwise");
        m_LYellow_RotateClockwise = m_LYellow.GetAction("RotateClockwise");
        // RPurple
        m_RPurple = asset.GetActionMap("RPurple");
        m_RPurple_Left = m_RPurple.GetAction("Left");
        m_RPurple_Right = m_RPurple.GetAction("Right");
        m_RPurple_Down = m_RPurple.GetAction("Down");
        m_RPurple_RotateCounterClockwise = m_RPurple.GetAction("RotateCounterClockwise");
        m_RPurple_RotateClockwise = m_RPurple.GetAction("RotateClockwise");
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Restart = m_Gameplay.GetAction("Restart");
    }

    ~Inputs()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // XBoxOne
    private InputActionMap m_XBoxOne;
    private IXBoxOneActions m_XBoxOneActionsCallbackInterface;
    private InputAction m_XBoxOne_Left;
    private InputAction m_XBoxOne_Right;
    private InputAction m_XBoxOne_Down;
    private InputAction m_XBoxOne_RotateCounterClockwise;
    private InputAction m_XBoxOne_RotateClockwise;
    public struct XBoxOneActions
    {
        private Inputs m_Wrapper;
        public XBoxOneActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_XBoxOne_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_XBoxOne_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_XBoxOne_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_XBoxOne_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_XBoxOne_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_XBoxOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(XBoxOneActions set) { return set.Get(); }
        public void SetCallbacks(IXBoxOneActions instance)
        {
            if (m_Wrapper.m_XBoxOneActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_XBoxOneActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_XBoxOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public XBoxOneActions @XBoxOne
    {
        get
        {
            return new XBoxOneActions(this);
        }
    }

    // LRed
    private InputActionMap m_LRed;
    private ILRedActions m_LRedActionsCallbackInterface;
    private InputAction m_LRed_Left;
    private InputAction m_LRed_Right;
    private InputAction m_LRed_Down;
    private InputAction m_LRed_RotateCounterClockwise;
    private InputAction m_LRed_RotateClockwise;
    public struct LRedActions
    {
        private Inputs m_Wrapper;
        public LRedActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_LRed_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_LRed_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_LRed_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_LRed_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_LRed_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_LRed; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(LRedActions set) { return set.Get(); }
        public void SetCallbacks(ILRedActions instance)
        {
            if (m_Wrapper.m_LRedActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_LRedActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_LRedActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_LRedActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_LRedActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_LRedActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_LRedActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_LRedActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_LRedActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_LRedActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_LRedActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_LRedActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_LRedActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_LRedActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_LRedActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_LRedActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_LRedActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public LRedActions @LRed
    {
        get
        {
            return new LRedActions(this);
        }
    }

    // RBrown
    private InputActionMap m_RBrown;
    private IRBrownActions m_RBrownActionsCallbackInterface;
    private InputAction m_RBrown_Left;
    private InputAction m_RBrown_Right;
    private InputAction m_RBrown_Down;
    private InputAction m_RBrown_RotateCounterClockwise;
    private InputAction m_RBrown_RotateClockwise;
    public struct RBrownActions
    {
        private Inputs m_Wrapper;
        public RBrownActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_RBrown_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_RBrown_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_RBrown_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_RBrown_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_RBrown_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_RBrown; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(RBrownActions set) { return set.Get(); }
        public void SetCallbacks(IRBrownActions instance)
        {
            if (m_Wrapper.m_RBrownActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_RBrownActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_RBrownActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_RBrownActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_RBrownActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_RBrownActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_RBrownActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_RBrownActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_RBrownActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public RBrownActions @RBrown
    {
        get
        {
            return new RBrownActions(this);
        }
    }

    // LGreen
    private InputActionMap m_LGreen;
    private ILGreenActions m_LGreenActionsCallbackInterface;
    private InputAction m_LGreen_Left;
    private InputAction m_LGreen_Right;
    private InputAction m_LGreen_Down;
    private InputAction m_LGreen_RotateCounterClockwise;
    private InputAction m_LGreen_RotateClockwise;
    public struct LGreenActions
    {
        private Inputs m_Wrapper;
        public LGreenActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_LGreen_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_LGreen_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_LGreen_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_LGreen_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_LGreen_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_LGreen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(LGreenActions set) { return set.Get(); }
        public void SetCallbacks(ILGreenActions instance)
        {
            if (m_Wrapper.m_LGreenActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_LGreenActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_LGreenActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_LGreenActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_LGreenActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_LGreenActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_LGreenActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_LGreenActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_LGreenActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public LGreenActions @LGreen
    {
        get
        {
            return new LGreenActions(this);
        }
    }

    // ROrange
    private InputActionMap m_ROrange;
    private IROrangeActions m_ROrangeActionsCallbackInterface;
    private InputAction m_ROrange_Left;
    private InputAction m_ROrange_Right;
    private InputAction m_ROrange_Down;
    private InputAction m_ROrange_RotateCounterClockwise;
    private InputAction m_ROrange_RotateClockwise;
    public struct ROrangeActions
    {
        private Inputs m_Wrapper;
        public ROrangeActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_ROrange_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_ROrange_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_ROrange_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_ROrange_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_ROrange_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_ROrange; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(ROrangeActions set) { return set.Get(); }
        public void SetCallbacks(IROrangeActions instance)
        {
            if (m_Wrapper.m_ROrangeActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_ROrangeActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_ROrangeActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public ROrangeActions @ROrange
    {
        get
        {
            return new ROrangeActions(this);
        }
    }

    // LBlue
    private InputActionMap m_LBlue;
    private ILBlueActions m_LBlueActionsCallbackInterface;
    private InputAction m_LBlue_Left;
    private InputAction m_LBlue_Right;
    private InputAction m_LBlue_Down;
    private InputAction m_LBlue_RotateCounterClockwise;
    private InputAction m_LBlue_RotateClockwise;
    public struct LBlueActions
    {
        private Inputs m_Wrapper;
        public LBlueActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_LBlue_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_LBlue_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_LBlue_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_LBlue_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_LBlue_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_LBlue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(LBlueActions set) { return set.Get(); }
        public void SetCallbacks(ILBlueActions instance)
        {
            if (m_Wrapper.m_LBlueActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_LBlueActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_LBlueActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_LBlueActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_LBlueActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_LBlueActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_LBlueActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_LBlueActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_LBlueActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public LBlueActions @LBlue
    {
        get
        {
            return new LBlueActions(this);
        }
    }

    // RTeal
    private InputActionMap m_RTeal;
    private IRTealActions m_RTealActionsCallbackInterface;
    private InputAction m_RTeal_Left;
    private InputAction m_RTeal_Right;
    private InputAction m_RTeal_Down;
    private InputAction m_RTeal_RotateCounterClockwise;
    private InputAction m_RTeal_RotateClockwise;
    public struct RTealActions
    {
        private Inputs m_Wrapper;
        public RTealActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_RTeal_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_RTeal_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_RTeal_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_RTeal_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_RTeal_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_RTeal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(RTealActions set) { return set.Get(); }
        public void SetCallbacks(IRTealActions instance)
        {
            if (m_Wrapper.m_RTealActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_RTealActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_RTealActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_RTealActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_RTealActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_RTealActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_RTealActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_RTealActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_RTealActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_RTealActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_RTealActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_RTealActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_RTealActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_RTealActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_RTealActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_RTealActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_RTealActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public RTealActions @RTeal
    {
        get
        {
            return new RTealActions(this);
        }
    }

    // LYellow
    private InputActionMap m_LYellow;
    private ILYellowActions m_LYellowActionsCallbackInterface;
    private InputAction m_LYellow_Left;
    private InputAction m_LYellow_Right;
    private InputAction m_LYellow_Down;
    private InputAction m_LYellow_RotateCounterClockwise;
    private InputAction m_LYellow_RotateClockwise;
    public struct LYellowActions
    {
        private Inputs m_Wrapper;
        public LYellowActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_LYellow_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_LYellow_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_LYellow_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_LYellow_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_LYellow_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_LYellow; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(LYellowActions set) { return set.Get(); }
        public void SetCallbacks(ILYellowActions instance)
        {
            if (m_Wrapper.m_LYellowActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_LYellowActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_LYellowActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_LYellowActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_LYellowActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_LYellowActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_LYellowActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_LYellowActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_LYellowActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public LYellowActions @LYellow
    {
        get
        {
            return new LYellowActions(this);
        }
    }

    // RPurple
    private InputActionMap m_RPurple;
    private IRPurpleActions m_RPurpleActionsCallbackInterface;
    private InputAction m_RPurple_Left;
    private InputAction m_RPurple_Right;
    private InputAction m_RPurple_Down;
    private InputAction m_RPurple_RotateCounterClockwise;
    private InputAction m_RPurple_RotateClockwise;
    public struct RPurpleActions
    {
        private Inputs m_Wrapper;
        public RPurpleActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left { get { return m_Wrapper.m_RPurple_Left; } }
        public InputAction @Right { get { return m_Wrapper.m_RPurple_Right; } }
        public InputAction @Down { get { return m_Wrapper.m_RPurple_Down; } }
        public InputAction @RotateCounterClockwise { get { return m_Wrapper.m_RPurple_RotateCounterClockwise; } }
        public InputAction @RotateClockwise { get { return m_Wrapper.m_RPurple_RotateClockwise; } }
        public InputActionMap Get() { return m_Wrapper.m_RPurple; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(RPurpleActions set) { return set.Get(); }
        public void SetCallbacks(IRPurpleActions instance)
        {
            if (m_Wrapper.m_RPurpleActionsCallbackInterface != null)
            {
                Left.started -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnLeft;
                Right.started -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRight;
                Down.started -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnDown;
                RotateCounterClockwise.started -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.performed -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRotateCounterClockwise;
                RotateClockwise.started -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.performed -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRotateClockwise;
                RotateClockwise.canceled -= m_Wrapper.m_RPurpleActionsCallbackInterface.OnRotateClockwise;
            }
            m_Wrapper.m_RPurpleActionsCallbackInterface = instance;
            if (instance != null)
            {
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
                RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
                RotateClockwise.started += instance.OnRotateClockwise;
                RotateClockwise.performed += instance.OnRotateClockwise;
                RotateClockwise.canceled += instance.OnRotateClockwise;
            }
        }
    }
    public RPurpleActions @RPurple
    {
        get
        {
            return new RPurpleActions(this);
        }
    }

    // Gameplay
    private InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private InputAction m_Gameplay_Restart;
    public struct GameplayActions
    {
        private Inputs m_Wrapper;
        public GameplayActions(Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Restart { get { return m_Wrapper.m_Gameplay_Restart; } }
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Restart.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRestart;
                Restart.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRestart;
                Restart.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Restart.started += instance.OnRestart;
                Restart.performed += instance.OnRestart;
                Restart.canceled += instance.OnRestart;
            }
        }
    }
    public GameplayActions @Gameplay
    {
        get
        {
            return new GameplayActions(this);
        }
    }
    public interface IXBoxOneActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface ILRedActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface IRBrownActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface ILGreenActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface IROrangeActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface ILBlueActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface IRTealActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface ILYellowActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface IRPurpleActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
    }
    public interface IGameplayActions
    {
        void OnRestart(InputAction.CallbackContext context);
    }
}
