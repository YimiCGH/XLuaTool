--package.cpath = package.cpath..'C:\\Users\\45502\\Desktop\\Lua\\'
--local rapidjson = package.loadlib('C:\\Users\\45502\\Desktop\\Lua\\rapidjson')
local rapidjson = require('rapidjson')
---[[
local t = rapidjson.decode('{"a":123}')
print(t.a)
t.a = 456
local s = rapidjson.encode(t)
print('json', s)
--]]
--[[
local t = rapidjson.load('C:\\Users\\45502\\Desktop\\Lua\\soldierData.json')
print(t.SoldierName)
t.SoldierName = '铁甲盾卫'
local s = rapidjson.encode(t)
print('json', s)
--]]