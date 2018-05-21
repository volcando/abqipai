local transform;
local gameObject;

dengluPanel = {};
local this = dengluPanel;

--启动事件--
function dengluPanel.Awake(obj)
    gameObject = obj;
    transform = obj.transform;

    this.InitPanel();
    logWarn("Awake lua--->>"..gameObject.name);
end

--初始化面板--
function dengluPanel.InitPanel()

end

--单击事件--
function dengluPanel.OnDestroy()
    logWarn("OnDestroy---->>>");
end