import { PlaceModel } from "./place.model";
import { PointerModel } from "./pointer.model";

export interface ElementModel {
  title?: string,
  value?:string,
  pointers?: PointerModel[],
  places?:PlaceModel[],
  id? : string,
  level?: number,
  fileCount?:string,
  hasChildren?: boolean,
  children?: ElementModel[]
}