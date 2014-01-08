/*
Navicat MySQL Data Transfer

Source Server         : hrms
Source Server Version : 50519
Source Host           : localhost:3306
Source Database       : hrms

Target Server Type    : MYSQL
Target Server Version : 50519
File Encoding         : 65001

Date: 2014-01-08 22:03:58
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for tb_branch
-- ----------------------------
DROP TABLE IF EXISTS `tb_branch`;
CREATE TABLE `tb_branch` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `branchNum` varchar(100) DEFAULT NULL,
  `branchName` varchar(100) DEFAULT NULL,
  `tel` varchar(50) DEFAULT NULL,
  `person` varchar(50) DEFAULT NULL,
  `branchInfo` text,
  `parentid` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_branch
-- ----------------------------
INSERT INTO `tb_branch` VALUES ('0', '100', '费县农商银行', null, null, null, null);
INSERT INTO `tb_branch` VALUES ('1', null, '农商银行领导班子成员', '5220011', '孙成文', null, '0');
INSERT INTO `tb_branch` VALUES ('2', null, '综合部', '5223658', '刘汉廷', null, '0');
INSERT INTO `tb_branch` VALUES ('3', null, '人力资源部', '5228089', '韩继红', null, '0');
INSERT INTO `tb_branch` VALUES ('4', null, '财务会计部', '5223606', '刘秀艳', null, '0');
INSERT INTO `tb_branch` VALUES ('5', null, '业务管理部', '5223686', '邓海舰', null, '0');
INSERT INTO `tb_branch` VALUES ('6', null, '资产管理部', '5220838', '杨晓黎', null, '0');
INSERT INTO `tb_branch` VALUES ('7', null, '审计部', '5226368', '邸现伟', null, '0');
INSERT INTO `tb_branch` VALUES ('8', null, '风险管控部', '5227658', '张红梅', null, '0');
INSERT INTO `tb_branch` VALUES ('9', null, '监察保卫部', '5228119', '徐百涛', null, '0');
INSERT INTO `tb_branch` VALUES ('10', null, '科技部', '5225398', '郑文静', null, '0');
INSERT INTO `tb_branch` VALUES ('11', null, '资金营运部', '5800977', '魏凤刚', null, '0');
INSERT INTO `tb_branch` VALUES ('12', null, '零售业务部', '5800966', '杨庆丽', null, '0');
INSERT INTO `tb_branch` VALUES ('13', null, '公司业务一部', '5220386', '赵  燕', null, '0');
INSERT INTO `tb_branch` VALUES ('14', null, '公司业务二部', '5011959', '吕振华', null, '0');
INSERT INTO `tb_branch` VALUES ('15', null, '营业部', '5227138', '吴传英', null, '0');
INSERT INTO `tb_branch` VALUES ('16', null, '城区支行', '5021719', '陈秀宇', null, '0');
INSERT INTO `tb_branch` VALUES ('17', null, '费城支行', '5012810', '李  涛', null, '0');
INSERT INTO `tb_branch` VALUES ('18', null, '探沂支行', '5611268', '刘秀军', null, '0');
INSERT INTO `tb_branch` VALUES ('19', null, '上冶支行', '5812345', '彭建民', null, '0');
INSERT INTO `tb_branch` VALUES ('20', null, '薛庄支行', '5871188', '钱余利', null, '0');
INSERT INTO `tb_branch` VALUES ('21', null, '新桥支行', '5788596', '郭淑华', null, '0');
INSERT INTO `tb_branch` VALUES ('22', null, '南张庄支行', '5831031', '曾丽川', null, '0');
INSERT INTO `tb_branch` VALUES ('23', null, '马庄支行', '5621059', '赵宝玉', null, '0');
INSERT INTO `tb_branch` VALUES ('24', null, '新庄支行', '5671696', '高玉峰', null, '0');
INSERT INTO `tb_branch` VALUES ('25', null, '梁邱支行', '5921838', '孙  冰', null, '0');
INSERT INTO `tb_branch` VALUES ('26', null, '方城支行', '5712123', '曹广清', null, '0');
INSERT INTO `tb_branch` VALUES ('27', null, '朱田支行', '5761692', '吕士龙', null, '0');
INSERT INTO `tb_branch` VALUES ('28', null, '汪沟支行', '5951109', '潘金民', null, '0');
INSERT INTO `tb_branch` VALUES ('29', null, '城北支行', '5081809', '鲁  超', null, '0');
INSERT INTO `tb_branch` VALUES ('30', null, '刘庄支行', '5641246', '袁季伟', null, '0');
INSERT INTO `tb_branch` VALUES ('31', null, '员外支行', '5061017', '吴传强', null, '0');
INSERT INTO `tb_branch` VALUES ('32', null, '胡阳支行', '5731235', '刘  青', null, '0');
INSERT INTO `tb_branch` VALUES ('33', null, '石井支行', '5981898', '韩  旭', null, '0');
INSERT INTO `tb_branch` VALUES ('34', null, '芍药山支行', '5691666', '邵明波', null, '0');
INSERT INTO `tb_branch` VALUES ('35', null, '大田庄支行', '5821017', '王  琳', null, '0');
INSERT INTO `tb_branch` VALUES ('36', null, '竹园支行', '5851079', '裴怀宝', null, '0');
INSERT INTO `tb_branch` VALUES ('37', null, '岩坡支行', '5931027', '丁纪洪', null, '0');
INSERT INTO `tb_branch` VALUES ('38', null, '水莲峪支行', '5751028', '吕永前', null, '0');
INSERT INTO `tb_branch` VALUES ('39', null, '郝家村支行', '5961656', '姜海良', null, '0');
INSERT INTO `tb_branch` VALUES ('40', null, '探沂开发区分理处', '5610678', '单娜', null, '18');
INSERT INTO `tb_branch` VALUES ('41', null, '胜利分理处', '5221849', '刘传涛', null, '16');
INSERT INTO `tb_branch` VALUES ('42', null, '胜兴分理处', '5223024', '窦宝民', null, '16');
INSERT INTO `tb_branch` VALUES ('43', null, '建设路分理处', '5028935', '刘  敏', null, '16');
INSERT INTO `tb_branch` VALUES ('44', null, '和平分理处', '5223463', '李士云', null, '16');
INSERT INTO `tb_branch` VALUES ('45', null, '团结分理处', '5222446', '杨  梅', null, '16');
INSERT INTO `tb_branch` VALUES ('46', null, '蒙台分理处', '5027400', '李  婧', null, '16');
INSERT INTO `tb_branch` VALUES ('47', null, '河东分理处', '5221730', '李修强', null, '17');
INSERT INTO `tb_branch` VALUES ('48', null, '钟罗山分理处', '5222049', '高  浩', null, '17');
INSERT INTO `tb_branch` VALUES ('49', null, '东郊分理处', '5012447', '张冠宇', null, '17');
INSERT INTO `tb_branch` VALUES ('50', null, '平等分理处', '5012425', '李  艳', null, '17');
INSERT INTO `tb_branch` VALUES ('51', null, '民主分理处', '5221020', '王晓燕', null, '17');
INSERT INTO `tb_branch` VALUES ('52', null, '自由路分理处', '5221047', '陈晓楠', null, '17');

-- ----------------------------
-- Table structure for tb_family
-- ----------------------------
DROP TABLE IF EXISTS `tb_family`;
CREATE TABLE `tb_family` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `relation` varchar(100) DEFAULT NULL,
  `birth` varchar(100) DEFAULT NULL,
  `tel` varchar(50) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `situation` varchar(200) DEFAULT NULL,
  `remark` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_family
-- ----------------------------
INSERT INTO `tb_family` VALUES ('1', '91810348', '张学琴', '父亲', '1960-05-06', '', '', '群众', '在岗', '');
INSERT INTO `tb_family` VALUES ('2', '91810348', '朱长勤', '母亲', '1962-10-13', '', '', '群众', '在岗', '');
INSERT INTO `tb_family` VALUES ('3', '91665020', '张杰', '配偶', '1986-06-04', '15588096120', '农商银行', '团员', '在岗', '');
INSERT INTO `tb_family` VALUES ('4', '91665251', '邸现伟', '女儿', '2001-12-12', null, '费县第二中学', '', '', '');
INSERT INTO `tb_family` VALUES ('5', '91665251', '邸现伟', '妻子', '1976-7-23', null, '', '', '', '');
INSERT INTO `tb_family` VALUES ('6', '91665251', '邸现伟', '母亲', '1940-1-2', null, '费县第三职业中学教师', '', '', '');
INSERT INTO `tb_family` VALUES ('7', '91665251', '邸现伟', '父亲', '1940-10-14', null, '吉林省白山林业局', '', '', '');
INSERT INTO `tb_family` VALUES ('8', '91665379', '杜广芬', '母子', '1996-11-24', null, '学生', '', '', '');
INSERT INTO `tb_family` VALUES ('9', '91665379', '杜广芬', '夫妻', '1971-2-25', null, '城区支行', '中共党员', '中共党员', '');
INSERT INTO `tb_family` VALUES ('10', '91665286', '韩光芳', '母子', '2010-5-25', null, '', '', '', '');
INSERT INTO `tb_family` VALUES ('11', '91665286', '韩光芳', '夫妻', '1983-8-21', null, '大田庄支行', '中共党员', '中共党员', '');
INSERT INTO `tb_family` VALUES ('12', '91665047', '李萍', '母女', '1998-8-24', null, '费县第二中学', '团员', '团员', '');
INSERT INTO `tb_family` VALUES ('13', '91665047', '李萍', '夫妻', '1972-8-24', null, '费县公安局经侦大队', '党员', '党员', '');
INSERT INTO `tb_family` VALUES ('14', '91665130', '刘蒙蒙', '母子', '2007-1-25', null, '上学', '', '', '');
INSERT INTO `tb_family` VALUES ('15', '91665130', '刘蒙蒙', '夫妻', '1981-6-16', null, '临沂拓普网络有限公司', '中共党员', '中共党员', '');
INSERT INTO `tb_family` VALUES ('16', '91665153', '周辉', '父亲', '1958-3-13', null, '农商行本部', '中共党员', '中共党员', '');
INSERT INTO `tb_family` VALUES ('17', '91665153', '周辉', '妻子', '1987-9-16', null, '上冶支行', '', '', '');
INSERT INTO `tb_family` VALUES ('18', '91665153', '周辉', '母亲', '1965-5-6', null, '', '', '', '');

-- ----------------------------
-- Table structure for tb_holidayrecords
-- ----------------------------
DROP TABLE IF EXISTS `tb_holidayrecords`;
CREATE TABLE `tb_holidayrecords` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `holiday` varchar(100) DEFAULT NULL,
  `days` float DEFAULT NULL,
  `reason` varchar(200) DEFAULT NULL,
  `audit` varchar(50) DEFAULT NULL,
  `begintime` varchar(50) DEFAULT NULL,
  `Endtime` varchar(50) DEFAULT NULL,
  `days1` float DEFAULT NULL,
  `remark` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_holidayrecords
-- ----------------------------

-- ----------------------------
-- Table structure for tb_learninfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_learninfo`;
CREATE TABLE `tb_learninfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `degree` varchar(50) DEFAULT NULL,
  `starttime` varchar(50) DEFAULT NULL,
  `graduatetime` varchar(50) DEFAULT NULL,
  `graduatesch` varchar(100) DEFAULT NULL,
  `retence` varchar(50) DEFAULT NULL,
  `profession` varchar(100) DEFAULT NULL,
  `content` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_learninfo
-- ----------------------------
INSERT INTO `tb_learninfo` VALUES ('1', '91665020', '本科', '2003-09', '2007-06', '山东财经大学', '刘波', '经济学', '');
INSERT INTO `tb_learninfo` VALUES ('2', '91665251', '初中', '1985-7-1', '1988-6-30', '吉林省临江林业局桦树镇初级中学', '高静', '', '');
INSERT INTO `tb_learninfo` VALUES ('3', '91665251', '高中', '1988-7-1', '1991-6-30', '费县第三职业中专', '任广生', '机电化工', '');
INSERT INTO `tb_learninfo` VALUES ('4', '91665251', '专科', '1998-9-1', '2001-6-30', '中共山东省委党校', '吴官正', '经济管理', '');
INSERT INTO `tb_learninfo` VALUES ('5', '91665379', '初中', '1982-9-1', '1985-6-30', '费县第五中学', '王法文', '', '');
INSERT INTO `tb_learninfo` VALUES ('6', '91665379', '高中', '1985-9-1', '1988-6-30', '费县第五中学', '冯志勇', '', '');
INSERT INTO `tb_learninfo` VALUES ('7', '91665379', '中专', '1991-9-1', '1993-7-15', '临沂职工中专学校', '冯国梁', '金融', '');
INSERT INTO `tb_learninfo` VALUES ('8', '91665379', '专科', '1994-9-1', '1997-7-15', '陕西财经学院', '周纪信', '金融', '');
INSERT INTO `tb_learninfo` VALUES ('9', '91665379', '本科', '2006-9-1', '2008-12-15', '中共山东省委党校', '姜异康', '经济管理', '');
INSERT INTO `tb_learninfo` VALUES ('10', '91665286', '初中', '1996-9-1', '1999-7-1', '费县大田庄乡中心初中', '李厚东', ' ', '');
INSERT INTO `tb_learninfo` VALUES ('11', '91665286', '中专', '1999-9-1', '2001-7-1', '临沂轻工业学校', '卢耀华', '会计电算化', '');
INSERT INTO `tb_learninfo` VALUES ('12', '91665286', '专科', '2001-9-1', '2004-7-1', '潍坊职业学院', '焦云', '会计学', '');
INSERT INTO `tb_learninfo` VALUES ('13', '91665286', '本科', '2004-9-1', '2006-7-1', '山东建筑大学', '杨宝龙', '会计学', '');
INSERT INTO `tb_learninfo` VALUES ('14', '91665047', '初中', '1985-9-1', '1987-6-30', '费县一中', '侯德启', '', '');
INSERT INTO `tb_learninfo` VALUES ('15', '91665047', '高中', '1987-9-1', '1990-6-30', '费县一中', '', '', '');
INSERT INTO `tb_learninfo` VALUES ('16', '91665047', '专科', '1999-9-1', '2002-6-30', '西安交通大学', '', '金融学', '');
INSERT INTO `tb_learninfo` VALUES ('17', '91665047', '本科', '2007-9-1', '2009-12-1', '山东省委党校', '', '法律', '');
INSERT INTO `tb_learninfo` VALUES ('18', '91665130', '初中', '1993-9-1', '1996-7-1', '费县二中', '王友峰', '', '');
INSERT INTO `tb_learninfo` VALUES ('19', '91665130', '高中', '1996-9-1', '1999-7-1', '费县二中', '杨厚军', '', '');
INSERT INTO `tb_learninfo` VALUES ('20', '91665130', '专科', '2000-9-1', '2002-7-1', '山东广播电视大学', '张岱斌', '法律', '');
INSERT INTO `tb_learninfo` VALUES ('21', '91665130', '本科', '2005-8-1', '2007-12-31', '中共中央党校函授学院', '黄士安', '经济管理', '');
INSERT INTO `tb_learninfo` VALUES ('22', '91665153', '初中', '1999-7-1', '2001-7-1', '费县二中', '高静', '', '');
INSERT INTO `tb_learninfo` VALUES ('23', '91665153', '高中', '2001-7-1', '2003-7-1', '费县实验中学', '张杰', '', '');
INSERT INTO `tb_learninfo` VALUES ('24', '91665153', '大学', '2004-7-1', '2007-7-1', '临沂师范学院', '张春华', '国际经济与贸易', '');

-- ----------------------------
-- Table structure for tb_perinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_perinfo`;
CREATE TABLE `tb_perinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `Beforename` varchar(50) DEFAULT NULL,
  `Employeeid` varchar(100) DEFAULT NULL,
  `Sex` varchar(10) DEFAULT NULL,
  `Nation` varchar(20) DEFAULT NULL,
  `Birth` varchar(100) DEFAULT NULL,
  `Idcard` varchar(50) DEFAULT NULL,
  `UnitID` int(11) DEFAULT NULL,
  `Unit` varchar(200) DEFAULT NULL,
  `Position` varchar(100) DEFAULT NULL,
  `Rank` varchar(20) DEFAULT NULL,
  `Level` int(11) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `Statustime` varchar(50) DEFAULT NULL,
  `Jobtime` varchar(50) DEFAULT NULL,
  `financetime` varchar(50) DEFAULT NULL,
  `fulltime_educ` varchar(50) DEFAULT NULL,
  `fulltime_sch` varchar(100) DEFAULT NULL,
  `Major` varchar(100) DEFAULT NULL,
  `Married` varchar(10) DEFAULT NULL,
  `Town` varchar(200) DEFAULT NULL,
  `Tel` varchar(20) DEFAULT NULL,
  `final_sch` varchar(100) DEFAULT NULL,
  `final_edu` varchar(100) DEFAULT NULL,
  `final_emajior` varchar(100) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `Reserve` varchar(100) DEFAULT NULL,
  `Guard` varchar(50) DEFAULT NULL,
  `Ages` int(10) DEFAULT NULL,
  `state` varchar(50) DEFAULT NULL,
  `employclass` varchar(100) DEFAULT NULL,
  `photo` varchar(200) DEFAULT NULL,
  `Attrion` varchar(100) DEFAULT NULL,
  `BankcardID` varchar(100) DEFAULT NULL,
  `remarks1` varchar(200) DEFAULT NULL,
  `remarks2` varchar(200) DEFAULT NULL,
  `Titles` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_perinfo
-- ----------------------------
INSERT INTO `tb_perinfo` VALUES ('13', '邸现伟', '', '91665251', '男', '汉族', '1972-5-23', '37283119720523005X', '2', '', '6', '普通员工', '1', '群众', '2009年', '', '', '本科', '', '', '已婚', '山东费县', '15969965216', '', '本科', '', '费县农村商业银行城区家属院', '', '编制内', '0', '5', '招聘学生', '/Photo/91665251/130333845892134334.jpg', '无', '', '', '', '');
INSERT INTO `tb_perinfo` VALUES ('14', '刘蒙蒙', '', '91665130', '女', '汉族', '1980-11-26', '371325198011260022', '0', '', '6', '普通员工', '1', '中共党员', '2010-12-4', '', '', '本科', '', '', '已婚', '山东费县', '13675395671', '', '本科', '', '临沂市费县信合村7号楼1单元401室', '', '编制内', '0', '5', '招聘学生', '/Photo/91665130/photo.jpg', '无', '', '', '', '');
INSERT INTO `tb_perinfo` VALUES ('15', '杜广芬', '', '91665379', '女', '汉族', '1970-1-6', '372831197001061223', '0', '', '7', '普通员工', '1', '群众', '', '', '', '本科', '', '', '已婚', '山东费用', '13646492078', '', '本科', '', '山东省费县信合村3号楼1单元302室', '', '编制内', '0', '5', '招聘学生', '/Photo/91665379/130333851048299249.jpg', '无', '', '', '', '');
INSERT INTO `tb_perinfo` VALUES ('16', '韩光芳', '韩娜', '91665286', '女', '汉族', '1983-12-3', '371302198312033443', '7', '', '7', '普通员工', '1', '中共党员', '2010-12-4', null, null, '本科', null, null, '已婚', '山东费用', '15963952906', null, '本科', null, '山东费县信合村1号楼2单元501室', '', '编制内', '0', '5', '招聘学生', null, '无', null, null, null, null);
INSERT INTO `tb_perinfo` VALUES ('17', '李萍', '', '91665047', '女', '汉族', '1973-4-5', '372831197304050564', '7', '', '7', '普通员工', '1', '', '', null, null, '本科', null, null, '已婚', '山东费县', '13468119558', null, '本科', null, '山东省费县平安巷2号3号楼3单元501室', '', '编制内', '0', '5', '招聘学生', null, '无', null, null, null, null);
INSERT INTO `tb_perinfo` VALUES ('18', '周辉', '', '91665153', '男', '汉族', '1987-9-5', '371325198709050019', '46', '', '9', '普通员工', '1', '团员', '', null, null, '本科', null, null, '已婚', '山东费县', '18763790736', null, '本科', null, '费县农村商业银行城区家属院', '', '编制内', '0', '5', '招聘学生', null, '无', null, null, null, null);
INSERT INTO `tb_perinfo` VALUES ('34', '陈磊', '', '91600000', '女', '汉族', '1899-12-31', '1234567892416', '6', '', '4', '普通员工', '1', '中共党员', '2014-01-05', '', '', '本科', '', '', '已婚', '山东费县', '18396797665', '', '本科', '', '信合村', '', '编制内', '0', '5', '招聘学生', '', '无', '', '', '', '');

-- ----------------------------
-- Table structure for tb_pertypeinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_pertypeinfo`;
CREATE TABLE `tb_pertypeinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `info` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_pertypeinfo
-- ----------------------------
INSERT INTO `tb_pertypeinfo` VALUES ('5', '在岗', '');
INSERT INTO `tb_pertypeinfo` VALUES ('6', '待岗', '');
INSERT INTO `tb_pertypeinfo` VALUES ('7', '内退', '');
INSERT INTO `tb_pertypeinfo` VALUES ('8', '病休', '');
INSERT INTO `tb_pertypeinfo` VALUES ('9', '协议离岗', '');
INSERT INTO `tb_pertypeinfo` VALUES ('10', '退休', '');
INSERT INTO `tb_pertypeinfo` VALUES ('11', '其他', '');

-- ----------------------------
-- Table structure for tb_positioninfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_positioninfo`;
CREATE TABLE `tb_positioninfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `info` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_positioninfo
-- ----------------------------
INSERT INTO `tb_positioninfo` VALUES ('4', '高层领导', '');
INSERT INTO `tb_positioninfo` VALUES ('5', '部室经理', '');
INSERT INTO `tb_positioninfo` VALUES ('6', '部室副经理', '');
INSERT INTO `tb_positioninfo` VALUES ('7', '办事员', '');
INSERT INTO `tb_positioninfo` VALUES ('8', '信贷专管员', '');
INSERT INTO `tb_positioninfo` VALUES ('9', '支行行长', '');
INSERT INTO `tb_positioninfo` VALUES ('10', '行长助理', '');
INSERT INTO `tb_positioninfo` VALUES ('11', '会计主管', '');
INSERT INTO `tb_positioninfo` VALUES ('12', '一般柜员', '');
INSERT INTO `tb_positioninfo` VALUES ('13', '综合柜员', '');
INSERT INTO `tb_positioninfo` VALUES ('14', '客户经理', '');
INSERT INTO `tb_positioninfo` VALUES ('15', '专职保卫岗', '');
INSERT INTO `tb_positioninfo` VALUES ('16', '营销岗', '');
INSERT INTO `tb_positioninfo` VALUES ('18', '其他工作岗位', '');

-- ----------------------------
-- Table structure for tb_registerinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_registerinfo`;
CREATE TABLE `tb_registerinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `cer_name` varchar(100) DEFAULT NULL,
  `accesstime` varchar(50) DEFAULT NULL,
  `issuingtime` varchar(50) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `Class` varchar(50) DEFAULT NULL,
  `photo` varchar(200) DEFAULT NULL,
  `description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_registerinfo
-- ----------------------------
INSERT INTO `tb_registerinfo` VALUES ('1', '91665020', '毕业证', '本科毕业证', '2007-06-30', '2007-06-30', '山东财经大学', '其他', '/Photo/130318379233125000.doc', '');
INSERT INTO `tb_registerinfo` VALUES ('2', '91665251', '毕业证书', '毕业证书', '2001-6-30', '2001-6-30', '中共山东省委党校', '省级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('3', '91665251', '会计从业资格证书', '会计从业资格证书', '2004-6-30', '2004-6-30', '山东省财政厅', '省级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('4', '91665251', '专业技术资格证书', '经济师专业技术资格证书', '2002-11-3', '2002-11-3', '中华人民共和国人事部', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('5', '91665251', '职业资格证书', '理财规划师职业资格证书', '2013-10-8', '2013-10-8', '人力资源和社会保障部', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('6', '91665251', '荣誉证书', '2012年度费县农村商业银行先进工作者', '2013-1-1', '2013-1-1', '费县农村商业银行', '县级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('7', '91665251', '银行从业资格证书', '中国银行业从业人员资格认证公共基础证书', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('8', '91665251', '银行从业资格证书', '中国银行业从业人员资格认证个人贷款证书', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('9', '91665379', '毕业证', '中级经济证', '2005-11-1', '2005-11-1', '人事部', '国家级', '/Photo/91665379/130333851229659623.jpg', '');
INSERT INTO `tb_registerinfo` VALUES ('10', '91665379', '毕业证', '二级人力资源师', '2012-8-20', '2012-8-20', '人力资源和社会劳动保障局', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('11', '91665379', '毕业证', '公共基础', '2012-10-28', '2013-1-1', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('12', '91665379', '毕业证', '个人理财', '2012-10-28', '2013-1-1', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('13', '91665379', '毕业证', '风险管理', '2012-10-28', '2013-1-1', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('14', '91665379', '毕业证', '个人贷款', '2013-6-30', '2013-8-8', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('15', '91665379', '毕业证', '公司信贷', '2013-6-30', '2013-8-8', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('16', '91665379', '毕业证', '会计从业证', '2002-1-8', '2002-1-8', '费县财政局', '县级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('17', '91665379', '毕业证', '本科毕业证', '2008-12-30', '2008-12-30', '山东省委党校', '省级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('18', '91665379', '荣誉证', '十佳文明服务明星', '2011-3-30', '2011-3-30', '费县精神文明建设委员会', '县级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('19', '91665379', '荣誉证', '优秀会计主管', '2011-1-15', '2011-1-15', '省联社临沂办事处', '市级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('20', '91665380', '荣誉证', '先进工作者', '2012-1-15', '2012-1-15', '费县农商银行', '县级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('21', '91665286', '资格证', '助理会计师', '2008-12-10', '2008-12-10', '人事局', '国家级 ', null, ' ');
INSERT INTO `tb_registerinfo` VALUES ('22', '91665286', '荣誉证书', '县级先进工作者', '2013-1-6', '2013-1-6', '费县农商银行', '县级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('23', '91665286', '资格证书', '会计从业资格证书', '2008-1-8', '2008-1-8', '费县财政局', '县级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('24', '91665286', '银行业从业人员资格', '公司信贷', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级 ', null, '');
INSERT INTO `tb_registerinfo` VALUES ('25', '91665286', '银行业从业人员资格', '个人理财', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级 ', null, '');
INSERT INTO `tb_registerinfo` VALUES ('26', '91665286', '银行业从业人员资格', '风险管理', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级 ', null, '');
INSERT INTO `tb_registerinfo` VALUES ('27', '91665286', '银行业从业人员资格', '公共基础', '2013-1-1', '2013-1-1', '中国银行业协会', '国家级 ', null, '');
INSERT INTO `tb_registerinfo` VALUES ('28', '91665286', '银行业从业人员资格', '个人贷款', '2013-1-1', '2013-1-1', '中国银行业协会', '国家级 ', null, '');
INSERT INTO `tb_registerinfo` VALUES ('29', '91665286', '毕业证', '本科毕业证', '2016-7-1', '2016-7-1', '山东建筑大学', '国家级 ', null, '');
INSERT INTO `tb_registerinfo` VALUES ('30', '91665286', '学位证', '本科学位证', '2016-7-1', '2016-7-1', '山东建筑大学', '国家级 ', null, '');
INSERT INTO `tb_registerinfo` VALUES ('31', '91665286', '资格证书', '二级人力资源师', '2012-2-15', '2012-2-15', '人力资源和社会保障部职业技能鉴定中心', '省级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('32', '91665047', ' 其他资格证书', '二级企业人力资源师', '2012-8-20', '2012-8.20', '人力资源和社会保障部职业技能鉴定中心', '国家级', null, '本列不填');
INSERT INTO `tb_registerinfo` VALUES ('33', '91665047', '会计证书', '会计从业资格证书', '2012-1-8', '2012-1-8', '费县财政局', '县级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('34', '91665047', '银行从业资格证书', '个人贷款', '2014-1-4', '2014-1-4', '中国银行业协会', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('35', '91665047', '银行从业资格证书', '个人理财', '2014-1-4', '2014-1-4', '中国银行业协会', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('36', '91665047', '银行从业资格证书', '风险管理', '2014-1-4', '2014-1-4', '中国银行业协会', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('37', '91665047', '荣誉证书', '先进工作者', '2012-1-12', '2012-1-12', '费县农村商业银行', '县级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('38', '91665130', '职称证', '中级人力资源师', '2012-2-15', '2012-2-15', '中华人民共和国人力资源和社会保障部', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('39', '91665130', '毕业证', '公共基础', '2012-1-1', '2012-1-1', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('40', '91665130', '毕业证', '个人贷款', '2012-1-1', '2012-1-1', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('41', '91665130', '毕业证', '公司信贷', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('42', '91665130', '毕业证', '个人理财', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('43', '91665130', '荣誉证', '“六进四联先进个人”', '2010-1-1', '2010-1-1', '临沂办事处', '市级', '', '');
INSERT INTO `tb_registerinfo` VALUES ('44', '91665130', '荣誉证', '《硕果累累》获得漫画类优秀作品奖', '2007-8-1', '2007-8-1', '山东省农村信用社联合社', '省级', '/Photo/91665130/photo.jpg', '');
INSERT INTO `tb_registerinfo` VALUES ('45', '91665153', '会计证书', '初级会计证', '2012-8-9', '2012-8-9', '会计从业', '省级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('46', '91665153', ' 毕业证', '毕业证', '2007-7-1', '2007-7-1', '临沂师范学院', '', null, '');
INSERT INTO `tb_registerinfo` VALUES ('47', '91665153', '职称证', '二级人力资源师', '2012-7-1', '2012-7-1', '中华人民共和国人力资源和社会保障部', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('48', '91665153', '荣誉证', '2009年度县级个人先进工作者', '2000-1-1', '2000-1-1', '费县农村信用社联社', '县级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('49', '91665153', '银行从业资格证', '个人贷款证书', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('50', '91665153', '银行从业资格证', '公司信贷证书', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级', null, '');
INSERT INTO `tb_registerinfo` VALUES ('51', '91665153', '银行从业资格证', '公共基础证书', '2013-8-8', '2013-8-8', '中国银行业协会', '国家级', null, '');

-- ----------------------------
-- Table structure for tb_reserve
-- ----------------------------
DROP TABLE IF EXISTS `tb_reserve`;
CREATE TABLE `tb_reserve` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ReserveType` varchar(100) DEFAULT NULL,
  `ReserveInfo` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_reserve
-- ----------------------------
INSERT INTO `tb_reserve` VALUES ('3', '中层正职后备人才', null);
INSERT INTO `tb_reserve` VALUES ('4', '中层副职后备人才', null);
INSERT INTO `tb_reserve` VALUES ('5', '会计主管后备人才', null);
INSERT INTO `tb_reserve` VALUES ('6', '分理处主任后备人才', null);
INSERT INTO `tb_reserve` VALUES ('7', '信贷主管后备人才', null);
INSERT INTO `tb_reserve` VALUES ('8', '业务技术能手', null);
INSERT INTO `tb_reserve` VALUES ('10', '其他后备人才类型', null);

-- ----------------------------
-- Table structure for tb_resumeinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_resumeinfo`;
CREATE TABLE `tb_resumeinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `attacktime` varchar(50) DEFAULT NULL,
  `quittime` varchar(100) DEFAULT NULL,
  `position` varchar(100) DEFAULT NULL,
  `unitid` int(11) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `mark` int(10) DEFAULT '0',
  `reason` text,
  `content` text,
  `audit` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=542 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_resumeinfo
-- ----------------------------
INSERT INTO `tb_resumeinfo` VALUES ('1', '91665020', '2007-08-18', '2008-07-20', '13', null, '2', '1', '调动', '柜员', '');
INSERT INTO `tb_resumeinfo` VALUES ('2', '91665020', '2008-08-20', '2013-12-15', '13', null, '3', '1', '调动', '人事工作', '');
INSERT INTO `tb_resumeinfo` VALUES ('3', '91665020', '2013-07-03', '2013-06-01', '9', null, '24', '1', '调动', '', '');
INSERT INTO `tb_resumeinfo` VALUES ('4', '91665020', '2013-07-03', '2013-07-20', '9', null, '36', '1', '调动', '', '');
INSERT INTO `tb_resumeinfo` VALUES ('5', '91665251', '1991-7-1', '1995-5-31', '职工', null, '费县纺织机械厂', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('6', '91665251', '1995-6-1', '2005-12-31', '营业柜员', null, '费县农村信用联社城区信用社', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('7', '91665251', '2006-1-1', '2007-12-31', '审计员', null, '费县农村信用联社审计部', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('8', '91665251', '2008-1-1', '2009-3-31', '会计主管', null, '费县农村信用联社新桥信用社', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('9', '91665251', '2009-4-1', '2010-3-31', '会计主管', null, '费县农村合作银行探沂支行', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('10', '91665251', '2010-4-1', '2011-1-15', '会计主管', null, '费县农村商业银行刘庄支行', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('11', '91665251', '2011-1-16', '2011-5-3', '信贷专管员', null, '费县农村商业银行业务管理部', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('12', '91665251', '2011-5-4', '2011-12-31', '部副经理', null, '费县农村商业银行检查考核中心', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('13', '91665251', '2012-1-1', '', '部经理', null, '7', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('14', '91665379', '1988-8-1', '1989-6-1', '一般柜员', null, '薛庄支行', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('15', '91665379', '1989-6-1', '1991-9-1', '一般柜员', null, '方城支行', '1', '学习', '学习', null);
INSERT INTO `tb_resumeinfo` VALUES ('16', '91665379', '1991-9-1', '1993-7-30', '学习', null, '临沂职工中专学校', '1', '毕业', '毕业', null);
INSERT INTO `tb_resumeinfo` VALUES ('17', '91665379', '1993-7-30', '1994-10-1', '一般柜员', null, '方城支行', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('18', '91665379', '1994-10-1', '2006-1-11', '主管会计', null, '薛庄支行', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('19', '91665379', '2006-1-11', '2008-1-11', '会计主管', null, '胡阳支行', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('20', '91665379', '2008-1-11', '2009-3-12', '会计主管', null, '探沂支行', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('21', '91665379', '2009-3-12', '2010-4-16', '会计主管', null, '上冶支行', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('22', '91665379', '2010-4-16', '2012-2-16', '会计主管', null, '营业部', '1', '正常调动', '正常调动', null);
INSERT INTO `tb_resumeinfo` VALUES ('23', '91665379', '2012-2-16', '2013-3-8', '事后监督组长', null, '财务会计部', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('24', '91665379', '2013-3-8', '', '副经理', null, '7', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('25', '91665286', '2006-7-7', '2010-4-12', '一般柜员', null, '朱田支行', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('26', '91665286', '2010-4-12', '', '审计员', null, '审计部', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('27', '91665047', '1991-3-1', '1996-1-6', '会计', null, '员外信用社', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('28', '91665047', '1996-1-6', '2006-1-7', '会计', null, '费城支行', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('29', '91665047', '2006-1-7', '2007-7-5', '结算员', null, '营业部', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('30', '91665047', '2007-7-5', '2013-4-1', '办事员', null, '审计部', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('31', '91665047', '2013-4-1', '', '事后监督员', null, '7', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('32', '91665130', '2003-11-29', '2004-5-3', '一般柜员', null, '费县方城信用社', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('33', '91665130', '2004-5-4', '2006-1-24', '一般柜员', null, '费县马庄信用社 ', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('34', '91665130', '2006-1-25', '2007-3-18', '一般柜员', null, '费县芍药山信用社', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('35', '91665130', '2007-3-19', '2009-5-23', '信贷内勤', null, '费县联社营业部 ', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('36', '91665130', '2009-5-24', '2010-4-12', '信贷内勤', null, '费城支行', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('37', '91665130', '2010-4-13', '2012-7-18', '办事员', null, '资产管理部 ', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('38', '91665130', '2012-7-19', '2012-12-31', '办事员', null, '检查考核中心', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('39', '91665130', '2013-1-3', '', '办事员', null, '7', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('40', '91665153', '2007-12-17', '2008-6-21', '一般柜员', null, '营业部', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('41', '91665153', '2008-6-21', '2008-7-21', '一般柜员', null, '蒙台分理处', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('42', '91665153', '2008-7-21', '2008-9-21', '一般柜员', null, '城区支行', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('43', '91665153', '2008-9-21', '2010-4-1', '一般柜员', null, '费城支行', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('44', '91665153', '2010-4-1', '', '审计员', null, '7', '1', '正常调动', '正常调动', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('45', '', '', '', '', null, '', '1', '', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('46', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('47', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('48', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('49', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('50', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('51', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('52', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('53', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('54', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('55', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('56', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('57', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('58', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('59', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('60', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('61', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('62', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('63', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('64', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('65', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('66', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('67', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('68', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('69', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('70', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('71', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('72', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('73', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('74', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('75', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('76', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('77', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('78', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('79', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('80', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('81', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('82', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('83', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('84', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('85', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('86', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('87', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('88', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('89', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('90', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('91', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('92', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('93', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('94', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('95', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('96', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('97', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('98', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('99', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('100', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('101', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('102', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('103', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('104', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('105', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('106', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('107', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('108', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('109', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('110', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('111', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('112', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('113', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('114', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('115', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('116', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('117', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('118', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('119', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('120', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('121', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('122', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('123', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('124', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('125', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('126', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('127', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('128', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('129', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('130', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('131', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('132', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('133', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('134', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('135', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('136', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('137', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('138', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('139', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('140', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('141', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('142', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('143', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('144', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('145', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('146', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('147', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('148', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('149', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('150', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('151', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('152', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('153', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('154', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('155', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('156', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('157', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('158', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('159', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('160', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('161', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('162', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('163', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('164', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('165', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('166', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('167', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('168', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('169', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('170', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('171', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('172', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('173', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('174', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('175', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('176', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('177', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('178', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('179', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('180', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('181', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('182', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('183', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('184', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('185', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('186', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('187', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('188', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('189', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('190', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('191', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('192', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('193', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('194', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('195', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('196', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('197', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('198', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('199', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('200', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('201', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('202', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('203', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('204', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('205', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('206', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('207', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('208', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('209', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('210', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('211', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('212', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('213', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('214', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('215', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('216', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('217', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('218', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('219', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('220', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('221', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('222', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('223', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('224', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('225', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('226', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('227', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('228', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('229', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('230', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('231', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('232', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('233', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('234', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('235', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('236', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('237', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('238', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('239', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('240', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('241', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('242', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('243', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('244', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('245', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('246', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('247', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('248', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('249', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('250', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('251', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('252', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('253', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('254', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('255', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('256', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('257', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('258', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('259', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('260', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('261', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('262', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('263', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('264', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('265', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('266', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('267', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('268', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('269', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('270', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('271', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('272', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('273', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('274', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('275', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('276', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('277', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('278', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('279', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('280', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('281', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('282', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('283', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('284', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('285', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('286', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('287', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('288', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('289', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('290', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('291', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('292', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('293', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('294', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('295', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('296', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('297', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('298', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('299', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('300', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('301', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('302', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('303', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('304', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('305', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('306', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('307', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('308', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('309', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('310', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('311', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('312', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('313', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('314', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('315', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('316', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('317', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('318', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('319', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('320', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('321', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('322', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('323', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('324', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('325', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('326', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('327', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('328', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('329', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('330', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('331', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('332', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('333', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('334', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('335', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('336', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('337', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('338', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('339', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('340', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('341', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('342', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('343', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('344', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('345', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('346', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('347', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('348', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('349', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('350', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('351', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('352', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('353', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('354', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('355', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('356', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('357', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('358', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('359', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('360', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('361', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('362', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('363', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('364', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('365', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('366', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('367', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('368', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('369', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('370', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('371', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('372', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('373', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('374', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('375', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('376', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('377', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('378', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('379', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('380', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('381', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('382', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('383', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('384', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('385', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('386', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('387', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('388', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('389', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('390', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('391', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('392', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('393', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('394', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('395', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('396', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('397', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('398', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('399', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('400', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('401', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('402', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('403', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('404', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('405', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('406', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('407', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('408', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('409', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('410', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('411', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('412', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('413', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('414', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('415', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('416', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('417', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('418', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('419', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('420', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('421', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('422', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('423', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('424', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('425', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('426', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('427', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('428', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('429', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('430', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('431', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('432', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('433', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('434', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('435', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('436', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('437', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('438', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('439', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('440', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('441', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('442', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('443', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('444', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('445', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('446', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('447', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('448', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('449', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('450', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('451', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('452', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('453', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('454', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('455', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('456', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('457', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('458', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('459', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('460', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('461', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('462', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('463', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('464', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('465', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('466', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('467', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('468', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('469', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('470', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('471', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('472', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('473', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('474', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('475', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('476', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('477', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('478', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('479', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('480', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('481', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('482', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('483', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('484', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('485', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('486', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('487', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('488', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('489', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('490', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('491', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('492', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('493', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('494', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('495', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('496', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('497', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('498', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('499', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('500', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('501', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('502', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('503', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('504', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('505', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('506', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('507', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('508', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('509', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('510', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('511', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('512', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('513', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('514', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('515', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('516', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('517', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('518', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('519', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('520', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('521', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('522', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('523', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('524', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('525', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('526', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('527', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('528', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('529', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('530', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('531', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('532', '', '', '', '', null, '', '0', '', '', null);
INSERT INTO `tb_resumeinfo` VALUES ('533', '91665251', '2014-01-01', '2014-01-05', '7', '2', '综合部', '1', '工作调动', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('534', '91665251', '2014-01-01', '2014-01-05', '7', '2', null, '1', '222', '111', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('535', '91600000', '', '', '7', '7', '审计部', '1', '', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('536', '91665153', '', '', '7', '7', '审计部', '1', '', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('537', '91600000', '', '', '7', '7', '审计部', '1', '', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('538', '91600000', '', '', '7', '7', '审计部', '1', '', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('539', '91600000', '', '', '7', '7', '审计部', '1', '', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('540', '91600000', '', '', '7', '7', '审计部', '1', '', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');
INSERT INTO `tb_resumeinfo` VALUES ('541', '91665153', '', '', '7', '7', '审计部', '1', '', '', '%e9%9f%a9%e7%bb%a7%e7%ba%a2');

-- ----------------------------
-- Table structure for tb_rewardinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_rewardinfo`;
CREATE TABLE `tb_rewardinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `time` varchar(50) DEFAULT NULL,
  `content` text,
  `department` varchar(100) DEFAULT NULL,
  `audit` varchar(20) DEFAULT NULL,
  `Class` varchar(50) DEFAULT NULL,
  `level` varchar(50) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `description` varchar(200) DEFAULT NULL,
  `mark` int(11) DEFAULT '0',
  `File` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_rewardinfo
-- ----------------------------
INSERT INTO `tb_rewardinfo` VALUES ('1', '100010', '惩罚', '2011-11-11', '见相关文件', '会计', '韩继红', '系统内县级', '', '会计', '', '1', '/Photo/130318397169687500.doc');

-- ----------------------------
-- Table structure for tb_users
-- ----------------------------
DROP TABLE IF EXISTS `tb_users`;
CREATE TABLE `tb_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `loginname` varchar(100) DEFAULT NULL,
  `userpwd` varchar(100) DEFAULT NULL,
  `username` varchar(100) DEFAULT NULL,
  `userprower` int(11) DEFAULT '0',
  `Unit` varchar(100) DEFAULT NULL,
  `remark` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_users
-- ----------------------------
INSERT INTO `tb_users` VALUES ('1', 'admin', '111', '管理员', '0', '支行', '基本信息维护');
INSERT INTO `tb_users` VALUES ('2', 'gaojing', '111111', '高静', '3', '人力资源部', '科员');
INSERT INTO `tb_users` VALUES ('3', 'hanjihong', '111111', '韩继红', '2', '人力资源部', '部经理');
INSERT INTO `tb_users` VALUES ('5', 'zhaojingcai', '111111', '赵京才', '1', '费县农商行监事长', '');

-- ----------------------------
-- Table structure for tb_workchange
-- ----------------------------
DROP TABLE IF EXISTS `tb_workchange`;
CREATE TABLE `tb_workchange` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `resumeid` int(11) DEFAULT NULL,
  `positionid` int(11) DEFAULT NULL,
  `unitid` int(11) DEFAULT NULL,
  `attacktime` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_workchange
-- ----------------------------
