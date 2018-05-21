require "Common/define"

require "3rd/pblua/login_pb"
require "3rd/pbc/protobuf"

local sproto = require "3rd/sproto/sproto"
local core = require "sproto.core"
local print_r = require "3rd/sproto/print_r"

dengluCtrl = {};
local this = dengluCtrl;

local denglu;
local prompt;
local transform;
local gameObject;

--构建函数--
function dengluCtrl.New()
    logWarn("dengluCtrl.New--->>");
    return this;
end

function dengluCtrl.Awake()
    logWarn("dengluCtrl.Awake--->>");
    panelMgr:CreatePanel('denglu', this.OnCreate);
end

--启动事件--
function dengluCtrl.OnCreate(obj)
    gameObject = obj;
    transform = obj.transform;


    logWarn("Start lua--->>"..gameObject.name);

    this.InitPanel();	--初始化面板--
   -- denglu:AddClick(dengluCtrl.btnOpen, this.OnClick);
end

--初始化面板--
function dengluCtrl.InitPanel()

end

--滚动项单击事件--
function dengluCtrl.OnItemClick(go)
    log(go.name);
end
