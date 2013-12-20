/*
Navicat MySQL Data Transfer

Source Server         : hrms
Source Server Version : 50519
Source Host           : localhost:3306
Source Database       : hrms

Target Server Type    : MYSQL
Target Server Version : 50519
File Encoding         : 65001

Date: 2013-12-20 16:31:05
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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_branch
-- ----------------------------
INSERT INTO `tb_branch` VALUES ('0', '100', '费县农商银行', null, null, null, null);
INSERT INTO `tb_branch` VALUES ('16', '001', '第一支行', '0539-8829568', '张三', '隶属费县农商', '0');
INSERT INTO `tb_branch` VALUES ('17', '00101', '上海路办事处', '0539-8829567', '王二', '隶属于第一支行', '16');
INSERT INTO `tb_branch` VALUES ('18', '0010101', '柜台', '0539-8829567-01', '张小兰', '负责前台业务', '17');
INSERT INTO `tb_branch` VALUES ('19', '0010102', '办公室', '0539-8829567-02', '王山川', '管理办事处', '17');
INSERT INTO `tb_branch` VALUES ('20', '0010103', '后勤', '0539-8829567-03', '刘平', '后勤保障', '17');
INSERT INTO `tb_branch` VALUES ('21', '002', '第二支行', '0539-8829566', '王五', '隶属费县农商', '0');
INSERT INTO `tb_branch` VALUES ('22', '00201', '山东路办事处', '0539-8829565', '张思', '隶属于第二支行', '21');
INSERT INTO `tb_branch` VALUES ('23', '0010201', '柜前', '0539-8829565-01', '宋张生', '测试', '22');

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_family
-- ----------------------------
INSERT INTO `tb_family` VALUES ('1', '100011', '张三', '父亲', '2013-12-04', '', '', '群众', '在岗', '');

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_learninfo
-- ----------------------------
INSERT INTO `tb_learninfo` VALUES ('1', '10010', '本科', '2013-02', '2013-03', '', '', '', '');

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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_perinfo
-- ----------------------------
INSERT INTO `tb_perinfo` VALUES ('14', 'ding', 'ccc', '0001', '男', '汉族', '1987-06-20', '371312198706206418', '0', '', '4', '普通员工', '1', '群众', '', '', '', '本科', '', '', '未婚', '', '', '', '本科', '', '', '', '编制内', '0', '5', '招聘学生', '', '无', '', '', '', '');
INSERT INTO `tb_perinfo` VALUES ('15', 'cccc', 'ddd', '0002', '男', '汉族', '', '', '23', '', '4', '普通员工', '1', '群众', '', '', '', '本科', '', '', '未婚', '', '', '', '本科', '', '', '', '编制内', '0', '5', '招聘学生', '', '无', '', '', '', '');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_registerinfo
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_resumeinfo
-- ----------------------------
INSERT INTO `tb_resumeinfo` VALUES ('11', '0002', '2013-12-01', '2013-12-26', '11', '23', '柜前', '1', '', '', '审核员');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_rewardinfo
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_users
-- ----------------------------
INSERT INTO `tb_users` VALUES ('13', 'admin', '111', '管理员', '0', '支行', '基本信息维护');
INSERT INTO `tb_users` VALUES ('16', 'inputer', '123', '信息录入员', '3', '分行', '负责信息录入');
INSERT INTO `tb_users` VALUES ('19', 'checker', '123', '审核员', '2', '分行', '123');
INSERT INTO `tb_users` VALUES ('20', 'selecter', '123', '查询员', '1', '办事处', '查询数据');
INSERT INTO `tb_users` VALUES ('21', 'selecter1', '123', '查询员1', '1', '办事处2', '查询相关数据');
INSERT INTO `tb_users` VALUES ('22', 'test', '123', '测试员', '2', '', '');
