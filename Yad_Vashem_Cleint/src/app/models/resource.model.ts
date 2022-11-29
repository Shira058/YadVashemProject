import { ElementModel } from "./element.model"
import { ResourceTypeEnum } from "./resource-type.enum"

export interface ResourceModel {
  title: string
  url: string,
  urlTitle: string,
  type: ResourceTypeEnum,
  elements: ElementModel[]
}