using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using System.Text.Json;
using YiJingFramework.Annotating.Zhouyi;
using Blazored.LocalStorage;
using Microsoft.JSInterop;

namespace ZhouyiStoreEditor.Pages.Editors
{
    public partial class HexagramEditor
    {
        public class Bindings
        {
            private readonly HexagramEditor editor;

            public Bindings(HexagramEditor editor)
            {
                this.editor = editor;
            }

            public string HexagramName
            {
                get
                {
                    return editor.selectedHexagram?.Name;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.Name = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }

            public string HexagramText
            {
                get
                {
                    return editor.selectedHexagram?.Text;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.Text = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }

            public string HexagramIndex
            {
                get
                {
                    return editor.selectedHexagram?.Index;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.Index = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }

            public string HexagramXiang
            {
                get
                {
                    return editor.selectedHexagram?.Xiang;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.Xiang = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }

            public string Tuan
            {
                get
                {
                    return editor.selectedHexagram?.Tuan;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.Tuan = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }

            public string Wenyan
            {
                get
                {
                    return editor.selectedHexagram?.Wenyan;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.Wenyan = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string FirstLineText
            {
                get
                {
                    return editor.selectedHexagram?.FirstLine?.LineText;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.FirstLine.LineText = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string FirstLineXiang
            {
                get
                {
                    return editor.selectedHexagram?.FirstLine?.Xiang;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.FirstLine.Xiang = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string SecondLineText
            {
                get
                {
                    return editor.selectedHexagram?.SecondLine?.LineText;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.SecondLine.LineText = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string SecondLineXiang
            {
                get
                {
                    return editor.selectedHexagram?.SecondLine?.Xiang;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.SecondLine.Xiang = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string ThirdLineText
            {
                get
                {
                    return editor.selectedHexagram?.ThirdLine?.LineText;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.ThirdLine.LineText = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string ThirdLineXiang
            {
                get
                {
                    return editor.selectedHexagram?.ThirdLine?.Xiang;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.ThirdLine.Xiang = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string FourthLineText
            {
                get
                {
                    return editor.selectedHexagram?.FourthLine?.LineText;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.FourthLine.LineText = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string FourthLineXiang
            {
                get
                {
                    return editor.selectedHexagram?.FourthLine?.Xiang;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.FourthLine.Xiang = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string FifthLineText
            {
                get
                {
                    return editor.selectedHexagram?.FifthLine?.LineText;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.FifthLine.LineText = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string FifthLineXiang
            {
                get
                {
                    return editor.selectedHexagram?.FifthLine?.Xiang;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.FifthLine.Xiang = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string SixthLineText
            {
                get
                {
                    return editor.selectedHexagram?.SixthLine?.LineText;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.SixthLine.LineText = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string SixthLineXiang
            {
                get
                {
                    return editor.selectedHexagram?.SixthLine?.Xiang;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.SixthLine.Xiang = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string YongText
            {
                get
                {
                    return editor.selectedHexagram?.Yong?.LineText;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.Yong.LineText = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
            public string YongXiang
            {
                get
                {
                    return editor.selectedHexagram?.Yong?.Xiang;
                }
                set
                {
                    if (editor.selectedHexagram is not null)
                    {
                        editor.selectedHexagram.Yong.Xiang = value;
                        editor.Store.UpdateStore(editor.selectedHexagram);
                    }
                }
            }
        }
    }
}
