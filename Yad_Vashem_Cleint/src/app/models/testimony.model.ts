import { ResourceModel } from "./resource.model";
import { TtranscriptSTRModel } from "./transcriptSTR.model"

export interface TestimonyModel {
  title: string,
  tag: string,
  url: string,
  infoText: string,
  isTestimonies:boolean,
  transcriptSTR:TtranscriptSTRModel[],
  transcriptDOC:string,
  moreInfo :string,
  images : string,
  resources: ResourceModel[],
}