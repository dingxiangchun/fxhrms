/*
Navicat MySQL Data Transfer

Source Server         : hrms
Source Server Version : 50519
Source Host           : localhost:3306
Source Database       : hrms

Target Server Type    : MYSQL
Target Server Version : 50519
File Encoding         : 65001

Date: 2013-11-16 18:23:42
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for tb_reserve
-- ----------------------------
DROP TABLE IF EXISTS `tb_reserve`;
CREATE TABLE `tb_reserve` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ReserveType` varchar(100) DEFAULT NULL,
  `ReserveInfo` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_reserve
-- ----------------------------
